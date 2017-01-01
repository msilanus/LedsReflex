namespace WindowsFormsApplication1
{
    partial class XxLEDSMASHERxX
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
            this.PIN = new System.Windows.Forms.ComboBox();
            this.TimeToFailButton = new System.Windows.Forms.Button();
            this.PinConnect = new System.Windows.Forms.Button();
            this.Levels = new System.Windows.Forms.GroupBox();
            this.score = new System.Windows.Forms.Label();
            this.rdbTopladder = new System.Windows.Forms.RadioButton();
            this.rdbHardcore = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbEzAF = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFin = new System.Windows.Forms.Label();
            this.Levels.SuspendLayout();
            this.SuspendLayout();
            // 
            // PIN
            // 
            this.PIN.FormattingEnabled = true;
            this.PIN.Location = new System.Drawing.Point(12, 12);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(632, 21);
            this.PIN.TabIndex = 0;
            this.PIN.SelectedIndexChanged += new System.EventHandler(this.PIN_SelectedIndexChanged);
            // 
            // TimeToFailButton
            // 
            this.TimeToFailButton.BackColor = System.Drawing.Color.Yellow;
            this.TimeToFailButton.Enabled = false;
            this.TimeToFailButton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeToFailButton.Location = new System.Drawing.Point(-14, 403);
            this.TimeToFailButton.Name = "TimeToFailButton";
            this.TimeToFailButton.Size = new System.Drawing.Size(786, 54);
            this.TimeToFailButton.TabIndex = 1;
            this.TimeToFailButton.Text = "Time to Fail";
            this.TimeToFailButton.UseVisualStyleBackColor = false;
            this.TimeToFailButton.Click += new System.EventHandler(this.TimeToFailButton_Click_1);
            // 
            // PinConnect
            // 
            this.PinConnect.Font = new System.Drawing.Font("Arnprior", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinConnect.Location = new System.Drawing.Point(656, 0);
            this.PinConnect.Name = "PinConnect";
            this.PinConnect.Size = new System.Drawing.Size(128, 87);
            this.PinConnect.TabIndex = 2;
            this.PinConnect.Text = "Connect";
            this.PinConnect.UseVisualStyleBackColor = true;
            this.PinConnect.Click += new System.EventHandler(this.PinConnect_Click);
            // 
            // Levels
            // 
            this.Levels.BackColor = System.Drawing.Color.Yellow;
            this.Levels.Controls.Add(this.lblFin);
            this.Levels.Controls.Add(this.btnReset);
            this.Levels.Controls.Add(this.score);
            this.Levels.Controls.Add(this.rdbTopladder);
            this.Levels.Controls.Add(this.rdbHardcore);
            this.Levels.Controls.Add(this.TimeToFailButton);
            this.Levels.Controls.Add(this.rdbMedium);
            this.Levels.Controls.Add(this.rdbEzAF);
            this.Levels.Enabled = false;
            this.Levels.Font = new System.Drawing.Font("Baveuse", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Levels.Location = new System.Drawing.Point(12, 93);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(772, 449);
            this.Levels.TabIndex = 3;
            this.Levels.TabStop = false;
            this.Levels.Text = "LEVELS";
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Baveuse", 171.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(90, -3);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(670, 367);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            this.score.Visible = false;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // rdbTopladder
            // 
            this.rdbTopladder.AutoSize = true;
            this.rdbTopladder.Font = new System.Drawing.Font("Baveuse", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTopladder.Location = new System.Drawing.Point(6, 203);
            this.rdbTopladder.Name = "rdbTopladder";
            this.rdbTopladder.Size = new System.Drawing.Size(289, 52);
            this.rdbTopladder.TabIndex = 3;
            this.rdbTopladder.Text = "TOP LADDER";
            this.rdbTopladder.UseVisualStyleBackColor = true;
            // 
            // rdbHardcore
            // 
            this.rdbHardcore.AutoSize = true;
            this.rdbHardcore.Font = new System.Drawing.Font("Baveuse", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHardcore.Location = new System.Drawing.Point(6, 145);
            this.rdbHardcore.Name = "rdbHardcore";
            this.rdbHardcore.Size = new System.Drawing.Size(262, 52);
            this.rdbHardcore.TabIndex = 2;
            this.rdbHardcore.Text = "HARDCORE";
            this.rdbHardcore.UseVisualStyleBackColor = true;
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.BackColor = System.Drawing.Color.Yellow;
            this.rdbMedium.Font = new System.Drawing.Font("Baveuse", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedium.Location = new System.Drawing.Point(6, 87);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(194, 52);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = false;
            // 
            // rdbEzAF
            // 
            this.rdbEzAF.AutoSize = true;
            this.rdbEzAF.BackColor = System.Drawing.Color.Yellow;
            this.rdbEzAF.Checked = true;
            this.rdbEzAF.Font = new System.Drawing.Font("Baveuse", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEzAF.Location = new System.Drawing.Point(6, 29);
            this.rdbEzAF.Name = "rdbEzAF";
            this.rdbEzAF.Size = new System.Drawing.Size(151, 52);
            this.rdbEzAF.TabIndex = 0;
            this.rdbEzAF.TabStop = true;
            this.rdbEzAF.Text = "Ez AF";
            this.rdbEzAF.UseVisualStyleBackColor = false;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 250000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(-14, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(786, 54);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(326, 296);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(0, 34);
            this.lblFin.TabIndex = 6;
            // 
            // XxLEDSMASHERxX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.Levels);
            this.Controls.Add(this.PinConnect);
            this.Controls.Add(this.PIN);
            this.Name = "XxLEDSMASHERxX";
            this.Text = "XxL3DSM4SH3RxX";
            this.Load += new System.EventHandler(this.XxLEDSMASHERxX_Load_1);
            this.Levels.ResumeLayout(false);
            this.Levels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PIN;
        private System.Windows.Forms.Button TimeToFailButton;
        private System.Windows.Forms.Button PinConnect;
        private System.Windows.Forms.GroupBox Levels;
        private System.Windows.Forms.RadioButton rdbHardcore;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbEzAF;
        private System.Windows.Forms.RadioButton rdbTopladder;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblFin;
    }
}

