namespace CyberShadowTrainer_WF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessStatusLabel = new System.Windows.Forms.Label();
            this.CurrentPositionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XPosLabel = new System.Windows.Forms.Label();
            this.YPosLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SavePosBtn = new System.Windows.Forms.Button();
            this.LoadPosBtn = new System.Windows.Forms.Button();
            this.SavedXPosTextBox = new System.Windows.Forms.TextBox();
            this.SavedYPosTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentHPLabel = new System.Windows.Forms.Label();
            this.CurrentSPLabel = new System.Windows.Forms.Label();
            this.CurrentMoneyLabel = new System.Windows.Forms.Label();
            this.UpdateHPTextBox = new System.Windows.Forms.TextBox();
            this.UpdateSPTextBox = new System.Windows.Forms.TextBox();
            this.UpdateMoneyTextBox = new System.Windows.Forms.TextBox();
            this.UpdateHPBtn = new System.Windows.Forms.Button();
            this.UpdateSPBtn = new System.Windows.Forms.Button();
            this.UpdateMoneyBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LockHPCheckBox = new System.Windows.Forms.CheckBox();
            this.LockSPCheckBox = new System.Windows.Forms.CheckBox();
            this.LockMoneyCheckBox = new System.Windows.Forms.CheckBox();
            this.LoadWithValsCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.HPLoadPosTextBox = new System.Windows.Forms.TextBox();
            this.SPLoadPosTextBox = new System.Windows.Forms.TextBox();
            this.MoneyLoadPosTextBox = new System.Windows.Forms.TextBox();
            this.SetLoadValuesCurrentBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.CurrentSubLabel = new System.Windows.Forms.Label();
            this.SubWepComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateSubBtn = new System.Windows.Forms.Button();
            this.LockSubHPCheckBox = new System.Windows.Forms.CheckBox();
            this.LockSubWepCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cyber Shadow Status:";
            // 
            // ProcessStatusLabel
            // 
            this.ProcessStatusLabel.AutoSize = true;
            this.ProcessStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProcessStatusLabel.Location = new System.Drawing.Point(125, 7);
            this.ProcessStatusLabel.Name = "ProcessStatusLabel";
            this.ProcessStatusLabel.Size = new System.Drawing.Size(50, 15);
            this.ProcessStatusLabel.TabIndex = 1;
            this.ProcessStatusLabel.Text = "CLOSED";
            // 
            // CurrentPositionLabel
            // 
            this.CurrentPositionLabel.AutoSize = true;
            this.CurrentPositionLabel.Location = new System.Drawing.Point(7, 125);
            this.CurrentPositionLabel.Name = "CurrentPositionLabel";
            this.CurrentPositionLabel.Size = new System.Drawing.Size(96, 15);
            this.CurrentPositionLabel.TabIndex = 2;
            this.CurrentPositionLabel.Text = "Current Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // XPosLabel
            // 
            this.XPosLabel.AutoSize = true;
            this.XPosLabel.Location = new System.Drawing.Point(31, 147);
            this.XPosLabel.Name = "XPosLabel";
            this.XPosLabel.Size = new System.Drawing.Size(28, 15);
            this.XPosLabel.TabIndex = 5;
            this.XPosLabel.Text = "###";
            // 
            // YPosLabel
            // 
            this.YPosLabel.AutoSize = true;
            this.YPosLabel.Location = new System.Drawing.Point(31, 171);
            this.YPosLabel.Name = "YPosLabel";
            this.YPosLabel.Size = new System.Drawing.Size(28, 15);
            this.YPosLabel.TabIndex = 6;
            this.YPosLabel.Text = "###";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saved Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "X:";
            // 
            // SavePosBtn
            // 
            this.SavePosBtn.Location = new System.Drawing.Point(12, 194);
            this.SavePosBtn.Name = "SavePosBtn";
            this.SavePosBtn.Size = new System.Drawing.Size(93, 23);
            this.SavePosBtn.TabIndex = 12;
            this.SavePosBtn.Text = "Save Position";
            this.SavePosBtn.UseVisualStyleBackColor = true;
            this.SavePosBtn.Click += new System.EventHandler(this.SavePosBtn_Click);
            // 
            // LoadPosBtn
            // 
            this.LoadPosBtn.Location = new System.Drawing.Point(148, 194);
            this.LoadPosBtn.Name = "LoadPosBtn";
            this.LoadPosBtn.Size = new System.Drawing.Size(93, 23);
            this.LoadPosBtn.TabIndex = 13;
            this.LoadPosBtn.Text = "Load Position";
            this.LoadPosBtn.UseVisualStyleBackColor = true;
            this.LoadPosBtn.Click += new System.EventHandler(this.LoadPosBtn_Click);
            // 
            // SavedXPosTextBox
            // 
            this.SavedXPosTextBox.Location = new System.Drawing.Point(148, 142);
            this.SavedXPosTextBox.Name = "SavedXPosTextBox";
            this.SavedXPosTextBox.Size = new System.Drawing.Size(100, 23);
            this.SavedXPosTextBox.TabIndex = 14;
            // 
            // SavedYPosTextBox
            // 
            this.SavedYPosTextBox.Location = new System.Drawing.Point(148, 167);
            this.SavedYPosTextBox.Name = "SavedYPosTextBox";
            this.SavedYPosTextBox.Size = new System.Drawing.Size(100, 23);
            this.SavedYPosTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current HP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Current SP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Current Money:";
            // 
            // CurrentHPLabel
            // 
            this.CurrentHPLabel.AutoSize = true;
            this.CurrentHPLabel.Location = new System.Drawing.Point(108, 36);
            this.CurrentHPLabel.Name = "CurrentHPLabel";
            this.CurrentHPLabel.Size = new System.Drawing.Size(14, 15);
            this.CurrentHPLabel.TabIndex = 19;
            this.CurrentHPLabel.Text = "#";
            // 
            // CurrentSPLabel
            // 
            this.CurrentSPLabel.AutoSize = true;
            this.CurrentSPLabel.Location = new System.Drawing.Point(108, 62);
            this.CurrentSPLabel.Name = "CurrentSPLabel";
            this.CurrentSPLabel.Size = new System.Drawing.Size(14, 15);
            this.CurrentSPLabel.TabIndex = 20;
            this.CurrentSPLabel.Text = "#";
            // 
            // CurrentMoneyLabel
            // 
            this.CurrentMoneyLabel.AutoSize = true;
            this.CurrentMoneyLabel.Location = new System.Drawing.Point(108, 88);
            this.CurrentMoneyLabel.Name = "CurrentMoneyLabel";
            this.CurrentMoneyLabel.Size = new System.Drawing.Size(14, 15);
            this.CurrentMoneyLabel.TabIndex = 21;
            this.CurrentMoneyLabel.Text = "#";
            // 
            // UpdateHPTextBox
            // 
            this.UpdateHPTextBox.Location = new System.Drawing.Point(147, 31);
            this.UpdateHPTextBox.Name = "UpdateHPTextBox";
            this.UpdateHPTextBox.Size = new System.Drawing.Size(100, 23);
            this.UpdateHPTextBox.TabIndex = 22;
            // 
            // UpdateSPTextBox
            // 
            this.UpdateSPTextBox.Location = new System.Drawing.Point(147, 58);
            this.UpdateSPTextBox.Name = "UpdateSPTextBox";
            this.UpdateSPTextBox.Size = new System.Drawing.Size(100, 23);
            this.UpdateSPTextBox.TabIndex = 23;
            // 
            // UpdateMoneyTextBox
            // 
            this.UpdateMoneyTextBox.Location = new System.Drawing.Point(147, 85);
            this.UpdateMoneyTextBox.Name = "UpdateMoneyTextBox";
            this.UpdateMoneyTextBox.Size = new System.Drawing.Size(100, 23);
            this.UpdateMoneyTextBox.TabIndex = 24;
            // 
            // UpdateHPBtn
            // 
            this.UpdateHPBtn.Location = new System.Drawing.Point(253, 30);
            this.UpdateHPBtn.Name = "UpdateHPBtn";
            this.UpdateHPBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateHPBtn.TabIndex = 25;
            this.UpdateHPBtn.Text = "Update";
            this.UpdateHPBtn.UseVisualStyleBackColor = true;
            this.UpdateHPBtn.Click += new System.EventHandler(this.UpdateHPBtn_Click);
            // 
            // UpdateSPBtn
            // 
            this.UpdateSPBtn.Location = new System.Drawing.Point(253, 58);
            this.UpdateSPBtn.Name = "UpdateSPBtn";
            this.UpdateSPBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateSPBtn.TabIndex = 26;
            this.UpdateSPBtn.Text = "Update";
            this.UpdateSPBtn.UseVisualStyleBackColor = true;
            this.UpdateSPBtn.Click += new System.EventHandler(this.UpdateSPBtn_Click);
            // 
            // UpdateMoneyBtn
            // 
            this.UpdateMoneyBtn.Location = new System.Drawing.Point(253, 85);
            this.UpdateMoneyBtn.Name = "UpdateMoneyBtn";
            this.UpdateMoneyBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateMoneyBtn.TabIndex = 27;
            this.UpdateMoneyBtn.Text = "Update";
            this.UpdateMoneyBtn.UseVisualStyleBackColor = true;
            this.UpdateMoneyBtn.Click += new System.EventHandler(this.UpdateMoneyBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Lock:";
            // 
            // LockHPCheckBox
            // 
            this.LockHPCheckBox.AutoSize = true;
            this.LockHPCheckBox.Location = new System.Drawing.Point(344, 34);
            this.LockHPCheckBox.Name = "LockHPCheckBox";
            this.LockHPCheckBox.Size = new System.Drawing.Size(15, 14);
            this.LockHPCheckBox.TabIndex = 29;
            this.LockHPCheckBox.UseVisualStyleBackColor = true;
            this.LockHPCheckBox.CheckedChanged += new System.EventHandler(this.LockHPCheckBox_CheckedChanged);
            // 
            // LockSPCheckBox
            // 
            this.LockSPCheckBox.AutoSize = true;
            this.LockSPCheckBox.Location = new System.Drawing.Point(344, 62);
            this.LockSPCheckBox.Name = "LockSPCheckBox";
            this.LockSPCheckBox.Size = new System.Drawing.Size(15, 14);
            this.LockSPCheckBox.TabIndex = 30;
            this.LockSPCheckBox.UseVisualStyleBackColor = true;
            this.LockSPCheckBox.CheckedChanged += new System.EventHandler(this.LockSPCheckBox_CheckedChanged);
            // 
            // LockMoneyCheckBox
            // 
            this.LockMoneyCheckBox.AutoSize = true;
            this.LockMoneyCheckBox.Location = new System.Drawing.Point(344, 89);
            this.LockMoneyCheckBox.Name = "LockMoneyCheckBox";
            this.LockMoneyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.LockMoneyCheckBox.TabIndex = 31;
            this.LockMoneyCheckBox.UseVisualStyleBackColor = true;
            this.LockMoneyCheckBox.CheckedChanged += new System.EventHandler(this.LockMoneyCheckBox_CheckedChanged);
            // 
            // LoadWithValsCheckBox
            // 
            this.LoadWithValsCheckBox.AutoSize = true;
            this.LoadWithValsCheckBox.Location = new System.Drawing.Point(269, 125);
            this.LoadWithValsCheckBox.Name = "LoadWithValsCheckBox";
            this.LoadWithValsCheckBox.Size = new System.Drawing.Size(160, 19);
            this.LoadWithValsCheckBox.TabIndex = 32;
            this.LoadWithValsCheckBox.Text = "Load Position with Values";
            this.LoadWithValsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(269, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 35;
            this.label11.Text = "Money:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "SP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(269, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "HP:";
            // 
            // HPLoadPosTextBox
            // 
            this.HPLoadPosTextBox.Location = new System.Drawing.Point(318, 142);
            this.HPLoadPosTextBox.Name = "HPLoadPosTextBox";
            this.HPLoadPosTextBox.Size = new System.Drawing.Size(24, 23);
            this.HPLoadPosTextBox.TabIndex = 36;
            // 
            // SPLoadPosTextBox
            // 
            this.SPLoadPosTextBox.Location = new System.Drawing.Point(318, 167);
            this.SPLoadPosTextBox.Name = "SPLoadPosTextBox";
            this.SPLoadPosTextBox.Size = new System.Drawing.Size(24, 23);
            this.SPLoadPosTextBox.TabIndex = 37;
            // 
            // MoneyLoadPosTextBox
            // 
            this.MoneyLoadPosTextBox.Location = new System.Drawing.Point(318, 193);
            this.MoneyLoadPosTextBox.Name = "MoneyLoadPosTextBox";
            this.MoneyLoadPosTextBox.Size = new System.Drawing.Size(24, 23);
            this.MoneyLoadPosTextBox.TabIndex = 38;
            // 
            // SetLoadValuesCurrentBtn
            // 
            this.SetLoadValuesCurrentBtn.Location = new System.Drawing.Point(348, 194);
            this.SetLoadValuesCurrentBtn.Name = "SetLoadValuesCurrentBtn";
            this.SetLoadValuesCurrentBtn.Size = new System.Drawing.Size(81, 23);
            this.SetLoadValuesCurrentBtn.TabIndex = 39;
            this.SetLoadValuesCurrentBtn.Text = "Use Current";
            this.SetLoadValuesCurrentBtn.UseVisualStyleBackColor = true;
            this.SetLoadValuesCurrentBtn.Click += new System.EventHandler(this.SetLoadValuesCurrentBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 15);
            this.label14.TabIndex = 40;
            this.label14.Text = "Current Sub Weapon:";
            // 
            // CurrentSubLabel
            // 
            this.CurrentSubLabel.AutoSize = true;
            this.CurrentSubLabel.Location = new System.Drawing.Point(131, 229);
            this.CurrentSubLabel.Name = "CurrentSubLabel";
            this.CurrentSubLabel.Size = new System.Drawing.Size(28, 15);
            this.CurrentSubLabel.TabIndex = 41;
            this.CurrentSubLabel.Text = "###";
            // 
            // SubWepComboBox
            // 
            this.SubWepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubWepComboBox.FormattingEnabled = true;
            this.SubWepComboBox.Location = new System.Drawing.Point(10, 247);
            this.SubWepComboBox.Name = "SubWepComboBox";
            this.SubWepComboBox.Size = new System.Drawing.Size(121, 23);
            this.SubWepComboBox.TabIndex = 42;
            // 
            // UpdateSubBtn
            // 
            this.UpdateSubBtn.Location = new System.Drawing.Point(147, 247);
            this.UpdateSubBtn.Name = "UpdateSubBtn";
            this.UpdateSubBtn.Size = new System.Drawing.Size(128, 23);
            this.UpdateSubBtn.TabIndex = 43;
            this.UpdateSubBtn.Text = "Update Sub Weapon";
            this.UpdateSubBtn.UseVisualStyleBackColor = true;
            this.UpdateSubBtn.Click += new System.EventHandler(this.UpdateSubBtn_Click);
            // 
            // LockSubHPCheckBox
            // 
            this.LockSubHPCheckBox.AutoSize = true;
            this.LockSubHPCheckBox.Location = new System.Drawing.Point(289, 250);
            this.LockSubHPCheckBox.Name = "LockSubHPCheckBox";
            this.LockSubHPCheckBox.Size = new System.Drawing.Size(93, 19);
            this.LockSubHPCheckBox.TabIndex = 44;
            this.LockSubHPCheckBox.Text = "Lock Sub HP";
            this.LockSubHPCheckBox.UseVisualStyleBackColor = true;
            // 
            // LockSubWepCheckBox
            // 
            this.LockSubWepCheckBox.AutoSize = true;
            this.LockSubWepCheckBox.Location = new System.Drawing.Point(289, 229);
            this.LockSubWepCheckBox.Name = "LockSubWepCheckBox";
            this.LockSubWepCheckBox.Size = new System.Drawing.Size(121, 19);
            this.LockSubWepCheckBox.TabIndex = 45;
            this.LockSubWepCheckBox.Text = "Lock Sub Weapon";
            this.LockSubWepCheckBox.UseVisualStyleBackColor = true;
            this.LockSubWepCheckBox.CheckedChanged += new System.EventHandler(this.LockSubWepCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 284);
            this.Controls.Add(this.LockSubWepCheckBox);
            this.Controls.Add(this.LockSubHPCheckBox);
            this.Controls.Add(this.UpdateSubBtn);
            this.Controls.Add(this.SubWepComboBox);
            this.Controls.Add(this.CurrentSubLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SetLoadValuesCurrentBtn);
            this.Controls.Add(this.MoneyLoadPosTextBox);
            this.Controls.Add(this.SPLoadPosTextBox);
            this.Controls.Add(this.HPLoadPosTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LoadWithValsCheckBox);
            this.Controls.Add(this.LockMoneyCheckBox);
            this.Controls.Add(this.LockSPCheckBox);
            this.Controls.Add(this.LockHPCheckBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UpdateMoneyBtn);
            this.Controls.Add(this.UpdateSPBtn);
            this.Controls.Add(this.UpdateHPBtn);
            this.Controls.Add(this.UpdateMoneyTextBox);
            this.Controls.Add(this.UpdateSPTextBox);
            this.Controls.Add(this.UpdateHPTextBox);
            this.Controls.Add(this.CurrentMoneyLabel);
            this.Controls.Add(this.CurrentSPLabel);
            this.Controls.Add(this.CurrentHPLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SavedYPosTextBox);
            this.Controls.Add(this.SavedXPosTextBox);
            this.Controls.Add(this.LoadPosBtn);
            this.Controls.Add(this.SavePosBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YPosLabel);
            this.Controls.Add(this.XPosLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentPositionLabel);
            this.Controls.Add(this.ProcessStatusLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Cyber Shadow Trainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label ProcessStatusLabel;
        private Label CurrentPositionLabel;
        private Label label2;
        private Label label3;
        private Label XPosLabel;
        private Label YPosLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private Label label7;
        private Label label8;
        private Button SavePosBtn;
        private Button LoadPosBtn;
        private TextBox SavedXPosTextBox;
        private TextBox SavedYPosTextBox;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label CurrentHPLabel;
        private Label CurrentSPLabel;
        private Label CurrentMoneyLabel;
        private TextBox UpdateHPTextBox;
        private TextBox UpdateSPTextBox;
        private TextBox UpdateMoneyTextBox;
        private Button UpdateHPBtn;
        private Button UpdateSPBtn;
        private Button UpdateMoneyBtn;
        private Label label10;
        private CheckBox LockHPCheckBox;
        private CheckBox LockSPCheckBox;
        private CheckBox LockMoneyCheckBox;
        private CheckBox LoadWithValsCheckBox;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox HPLoadPosTextBox;
        private TextBox SPLoadPosTextBox;
        private TextBox MoneyLoadPosTextBox;
        private Button SetLoadValuesCurrentBtn;
        private Label label14;
        private Label CurrentSubLabel;
        private ComboBox SubWepComboBox;
        private Button UpdateSubBtn;
        private CheckBox LockSubHPCheckBox;
        private CheckBox LockSubWepCheckBox;
    }
}