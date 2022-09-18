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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current HP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Current SP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Current Money:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "#";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "#";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "#";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 227);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
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
        private Label label10;
        private Label label11;
        private Label label12;
    }
}