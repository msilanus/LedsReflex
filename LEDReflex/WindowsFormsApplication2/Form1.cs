using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class XxLEDSMASHERxX : Form
    {
        string Rx;
        public XxLEDSMASHERxX()
        {
            InitializeComponent();
        }


        private void PIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PinConnect_Click(object sender, EventArgs e)
        {
            TimeToFailButton.Enabled = true;
            Levels.Enabled = true;
            serialPort1.PortName = PIN.Text;
            serialPort1.Open();
        }


        private void XxLEDSMASHERxX_Load_1(object sender, EventArgs e)
        {
            foreach (string serialname in System.IO.Ports.SerialPort.GetPortNames()) PIN.Items.Add(serialname);
        }

        private void TimeToFailButton_Click_1(object sender, EventArgs e)
        {
            if (rdbMedium.Checked == true) serialPort1.Write("M");
            if (rdbHardcore.Checked == true) serialPort1.Write("H");
            if (rdbEzAF.Checked == true) serialPort1.Write("F");
            if (rdbTopladder.Checked == true) serialPort1.Write("E");
            PIN.Visible = false;
            PinConnect.Visible = false;
            
            TimeToFailButton.Visible = false;
            score.Visible = true;
            
            rdbMedium.Visible = false;
            Levels.Text = "Score";
            rdbTopladder.Visible = false;
            rdbEzAF.Visible = false;
            rdbHardcore.Visible = false;
            timer1.Enabled = true;
        }

        private void score_Click(object sender, EventArgs e)
        {

            //serialPort1.Read("");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Rx != "Q")
                score.Text = Rx;
            else
            {
                lblFin.Text = "Partie Terminée";
                timer1.Enabled = false;
                btnReset.Enabled = true;
                btnReset.Visible = true;
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Application.Restart();
       }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Rx = serialPort1.ReadTo("\r\n");
        } 
    }

}
