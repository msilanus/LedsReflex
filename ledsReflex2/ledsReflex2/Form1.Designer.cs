namespace ledsReflex2
{
    partial class formLedsReflex
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btPort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbNiveaux = new System.Windows.Forms.GroupBox();
            this.rbVeryHard = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbNiveaux.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(872, 20);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btPort
            // 
            this.btPort.Location = new System.Drawing.Point(352, 30);
            this.btPort.Name = "btPort";
            this.btPort.Size = new System.Drawing.Size(97, 23);
            this.btPort.TabIndex = 5;
            this.btPort.Text = "Modifier";
            this.btPort.UseVisualStyleBackColor = true;
            this.btPort.Click += new System.EventHandler(this.btPort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            // 
            // gbNiveaux
            // 
            this.gbNiveaux.Controls.Add(this.rbVeryHard);
            this.gbNiveaux.Controls.Add(this.rbHard);
            this.gbNiveaux.Controls.Add(this.rbMedium);
            this.gbNiveaux.Controls.Add(this.rbEasy);
            this.gbNiveaux.Location = new System.Drawing.Point(12, 94);
            this.gbNiveaux.Name = "gbNiveaux";
            this.gbNiveaux.Size = new System.Drawing.Size(277, 406);
            this.gbNiveaux.TabIndex = 7;
            this.gbNiveaux.TabStop = false;
            this.gbNiveaux.Text = "Niveau de jeu";
            // 
            // rbVeryHard
            // 
            this.rbVeryHard.AutoSize = true;
            this.rbVeryHard.Font = new System.Drawing.Font("Mistral", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVeryHard.ForeColor = System.Drawing.Color.Red;
            this.rbVeryHard.Location = new System.Drawing.Point(22, 307);
            this.rbVeryHard.Name = "rbVeryHard";
            this.rbVeryHard.Size = new System.Drawing.Size(237, 61);
            this.rbVeryHard.TabIndex = 3;
            this.rbVeryHard.Text = "VERY HARD";
            this.rbVeryHard.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Mistral", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbHard.Location = new System.Drawing.Point(19, 217);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(140, 61);
            this.rbHard.TabIndex = 2;
            this.rbHard.Text = "HARD";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Mistral", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.ForeColor = System.Drawing.Color.Green;
            this.rbMedium.Location = new System.Drawing.Point(22, 127);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(188, 61);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Text = "MEDIUM";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Font = new System.Drawing.Font("Mistral", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbEasy.Location = new System.Drawing.Point(22, 37);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(126, 61);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "EASY";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResultat);
            this.groupBox3.Controls.Add(this.lblScore);
            this.groupBox3.Controls.Add(this.btStart);
            this.groupBox3.Location = new System.Drawing.Point(295, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 406);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Score";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(6, 21);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(595, 49);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Visible = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Courier New", 52.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(6, 127);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(595, 101);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "3";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Visible = false;
            // 
            // lblResultat
            // 
            this.lblResultat.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.ForeColor = System.Drawing.Color.Red;
            this.lblResultat.Location = new System.Drawing.Point(6, 239);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(595, 164);
            this.lblResultat.TabIndex = 2;
            this.lblResultat.Text = "Bonne chance !";
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultat.Visible = false;
            // 
            // formLedsReflex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbNiveaux);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "formLedsReflex";
            this.Text = "LedsReflex2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbNiveaux.ResumeLayout(false);
            this.gbNiveaux.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbNiveaux;
        private System.Windows.Forms.RadioButton rbVeryHard;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblScore;
    }
}

