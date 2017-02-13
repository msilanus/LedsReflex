using System;
using System.Management;
using System.Collections.Generic;
using System.IO.Ports;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ledsReflex2
{
    public partial class formLedsReflex : Form
    {
        private String Rx="";
        private String oldRx="";
        private SoundPlayer ok;
        private SoundPlayer echec;
        private SoundPlayer win;
        private SoundPlayer sad;
        private int score = 0;
        private int oldSocore = 0;
        public formLedsReflex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string arduinoLine="";
            string arduPort="";
            int arduinoItem = -1;

            ok = new SoundPlayer(@"ok.wav");
            echec = new SoundPlayer(@"echec.wav");
            win = new SoundPlayer(@"win.wav");
            sad = new SoundPlayer(@"sad.wav");

            using (var searcher = new ManagementObjectSearcher
                ("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                             join p in ports on n equals p["DeviceID"].ToString()
                             select n + " - " + p["Caption"]).ToList();
                
                foreach (string s in tList)
                {
                    comboBox1.Items.Add(s);
                    if (s.Contains("Arduino")) 
                    {
                        arduinoLine = s;
                        arduinoItem = comboBox1.Items.IndexOf(s);
                        arduPort = s.Substring(0,5).Replace(" ",string.Empty);
                    }
                }
                if (arduinoItem > -1)
                {
                    comboBox1.SelectedIndex = arduinoItem;
                    serialPort1.PortName = arduPort;
                    try
                    {
                        serialPort1.Open();
                        toolStripStatusLabel1.Text = "Connecté à " + arduinoLine;
                        comboBox1.Enabled = false;
                        btStart.Visible = true;
                    }
                    catch
                    {
                        DialogResult result;
                        result = MessageBox.Show("Impossible d'ouvrir le port " + serialPort1.PortName + " !\n" +
                                                 "Ce port est peut être déja ouvert.\n" +
                                                 "Voulez-vous recommencé ?" 
                                                 , "Erreur !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes) Application.Restart();
                        else Application.Exit();
                    }
                }
                else
                {
                    DialogResult result;
                    result=MessageBox.Show("Pas de carte Arduino détectée !\nConnectez une Arduino maintenant.", "Erreur !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.OK) Application.Restart();
                    else Application.Exit();
                }
                
            } 
        }

        private void btPort_Click(object sender, EventArgs e)
        {
            if (btPort.Text == "Connecter")
            {
                timer1.Enabled = false;
                serialPort1.Close();
                serialPort1.PortName = comboBox1.SelectedItem.ToString().Substring(0, 5).Replace(" ", string.Empty);
                try
                { 
                    serialPort1.Open();
                    comboBox1.Enabled = false;
                    btPort.Text = "Modifier";
                    toolStripStatusLabel1.Text = "Connecté à " + comboBox1.SelectedItem.ToString();
                    timer1.Enabled = true;
                    serialPort1.Write("STATUS\n");
                }
                catch
                {
                    DialogResult result;
                    result = MessageBox.Show("Impossible d'ouvrir le port " + serialPort1.PortName + " !\n" +
                                                 "Ce port est peut être déja ouvert.\n" +
                                                 "Voulez-vous recommencé ?"
                                                 , "Erreur !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes) Application.Restart();
                    else Application.Exit();
                }
            }
            else if (comboBox1.Enabled)
            {
                comboBox1.Enabled = false;
                btPort.Text = "Modifier";
            }
            else
            {
                comboBox1.Enabled = true;
                btPort.Text = "Connecter";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Rx = serialPort1.ReadTo("\r\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Rx != oldRx)
            {
                switch (Rx)
                {
                    case "3": lblScore.ForeColor = Color.Red; break;
                    case "2": lblScore.ForeColor = Color.OrangeRed; break;
                    case "1": lblScore.ForeColor = Color.OrangeRed; break;
                    case "0": lblResultat.Text = "Joue ..."; lblScore.ForeColor = Color.Green; break;
                    case "Q": 
                        lblResultat.Text = "Partie Terminée";
                        timer1.Enabled = false;
                        btStart.Enabled = true;
                        gbNiveaux.Enabled = true;
                        if (score > 29)
                        {
                            lblResultat.ForeColor = Color.Green;
                            lblResultat.Text += "\nSuper !!!";
                            win.Play(); 
                        }
                        else 
                        {
                            lblResultat.ForeColor = Color.Red;
                            lblResultat.Text += "\nBeuuurk !!!";
                            sad.Play();
                        }
                        break;
                    default:
                        char[] sep = { ' ', '/', ' ' };
                        string[] strScore = Rx.Split(sep);

                        score = Convert.ToInt16(strScore[0]);
                        int sur = Convert.ToInt16(strScore[3]);
                        if (score == sur) lblScore.ForeColor = Color.Green;
                        else if (score > sur - 11) lblScore.ForeColor = Color.OrangeRed;
                        else lblScore.ForeColor = Color.Red;
                        if (score > oldSocore) ok.Play();
                        else if(sur>0) echec.Play();

                        oldSocore = score;

                        break;
                }
                if (Rx != "Q")
                {
                    lblScore.Text = Rx;
                }
            }
            oldRx = Rx;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (rbMedium.Checked == true) serialPort1.Write("M");
            if (rbHard.Checked == true) serialPort1.Write("H");
            if (rbEasy.Checked == true) serialPort1.Write("F");
            if (rbVeryHard.Checked == true) serialPort1.Write("E");

            lblResultat.Text = "Attention !";
            lblResultat.Visible = true;

            lblScore.Visible = true;

            btStart.Enabled = false;

            gbNiveaux.Enabled = false;

            timer1.Enabled = true;
        }




    }
}
