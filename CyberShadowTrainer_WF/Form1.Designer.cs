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
            this.SavedYPosLabel = new System.Windows.Forms.Label();
            this.SavedXPosLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SavePosBtn = new System.Windows.Forms.Button();
            this.LoadPosBtn = new System.Windows.Forms.Button();
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
            this.CurrentPositionLabel.Location = new System.Drawing.Point(7, 34);
            this.CurrentPositionLabel.Name = "CurrentPositionLabel";
            this.CurrentPositionLabel.Size = new System.Drawing.Size(96, 15);
            this.CurrentPositionLabel.TabIndex = 2;
            this.CurrentPositionLabel.Text = "Current Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // XPosLabel
            // 
            this.XPosLabel.AutoSize = true;
            this.XPosLabel.Location = new System.Drawing.Point(31, 52);
            this.XPosLabel.Name = "XPosLabel";
            this.XPosLabel.Size = new System.Drawing.Size(28, 15);
            this.XPosLabel.TabIndex = 5;
            this.XPosLabel.Text = "###";
            // 
            // YPosLabel
            // 
            this.YPosLabel.AutoSize = true;
            this.YPosLabel.Location = new System.Drawing.Point(31, 67);
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
            this.label4.Location = new System.Drawing.Point(125, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saved Position:";
            // 
            // SavedYPosLabel
            // 
            this.SavedYPosLabel.AutoSize = true;
            this.SavedYPosLabel.Location = new System.Drawing.Point(148, 67);
            this.SavedYPosLabel.Name = "SavedYPosLabel";
            this.SavedYPosLabel.Size = new System.Drawing.Size(28, 15);
            this.SavedYPosLabel.TabIndex = 11;
            this.SavedYPosLabel.Text = "###";
            // 
            // SavedXPosLabel
            // 
            this.SavedXPosLabel.AutoSize = true;
            this.SavedXPosLabel.Location = new System.Drawing.Point(148, 52);
            this.SavedXPosLabel.Name = "SavedXPosLabel";
            this.SavedXPosLabel.Size = new System.Drawing.Size(28, 15);
            this.SavedXPosLabel.TabIndex = 10;
            this.SavedXPosLabel.Text = "###";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "X:";
            // 
            // SavePosBtn
            // 
            this.SavePosBtn.Location = new System.Drawing.Point(8, 95);
            this.SavePosBtn.Name = "SavePosBtn";
            this.SavePosBtn.Size = new System.Drawing.Size(93, 23);
            this.SavePosBtn.TabIndex = 12;
            this.SavePosBtn.Text = "Save Position";
            this.SavePosBtn.UseVisualStyleBackColor = true;
            this.SavePosBtn.Click += new System.EventHandler(this.SavePosBtn_Click);
            // 
            // LoadPosBtn
            // 
            this.LoadPosBtn.Location = new System.Drawing.Point(125, 95);
            this.LoadPosBtn.Name = "LoadPosBtn";
            this.LoadPosBtn.Size = new System.Drawing.Size(93, 23);
            this.LoadPosBtn.TabIndex = 13;
            this.LoadPosBtn.Text = "Load Position";
            this.LoadPosBtn.UseVisualStyleBackColor = true;
            this.LoadPosBtn.Click += new System.EventHandler(this.LoadPosBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 189);
            this.Controls.Add(this.LoadPosBtn);
            this.Controls.Add(this.SavePosBtn);
            this.Controls.Add(this.SavedYPosLabel);
            this.Controls.Add(this.SavedXPosLabel);
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
        private Label SavedYPosLabel;
        private Label SavedXPosLabel;
        private Label label7;
        private Label label8;
        private Button SavePosBtn;
        private Button LoadPosBtn;
    }
}