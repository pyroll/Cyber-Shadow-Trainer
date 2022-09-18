using CSHacking;
using Memory;
using System.Diagnostics;

namespace CyberShadowTrainer_WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            int idF2 = 0; // The id of the hotkey F2
            int idF4 = 1; // The id of the hotkey F4
            RegisterHotKey(this.Handle, idF2, (int)KeyModifier.None, Keys.F2.GetHashCode());
            RegisterHotKey(this.Handle, idF4, (int)KeyModifier.None, Keys.F4.GetHashCode());
        }

        public Mem m = new Mem();
        public CSHackingClass CSHacking = new CSHackingClass();

        private string hpToLock;
        private string spToLock;
        private string moneyToLock;

        #region Global Hotkeys

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id,
                                   int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                // Get id of hotkey pressed, run correct method based on it
                int id = m.WParam.ToInt32();

                // If F2 was pressed
                if (id == 0)
                {
                    UISavePlayerPos();
                }
                else if (id == 1)
                {
                    UILoadPlayerPos();
                }

                Debug.Write("Hotkey has been pressed!");
            }
        }        

        #endregion

        // Properties for saving coordinates
        private double savedXPos;
        private double savedYPos;

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                bool IsProcRunning = CSHacking.CheckIfProcOpen();

                if (IsProcRunning)
                {
                    // Change text to 'OPEN'
                    ProcessStatusLabel.Invoke((MethodInvoker)delegate
                    {
                        ProcessStatusLabel.ForeColor = Color.DarkGreen;
                        ProcessStatusLabel.Text = "OPEN";
                    });

                    // Get Player coordinates
                    double[] playerPosition = CSHacking.ReadPlayerPOS();

                    // Update Current Position on UI
                    XPosLabel.Invoke((MethodInvoker)delegate
                    {
                        XPosLabel.Text = playerPosition[0].ToString();
                    });
                    YPosLabel.Invoke((MethodInvoker)delegate
                    {
                        YPosLabel.Text = playerPosition[1].ToString();
                    });

                    // Read and Update Current HP, SP, Money Labels
                    double hp = CSHacking.ReadHPValue();
                    double sp = CSHacking.ReadSPValue();
                    double money = CSHacking.ReadMoneyValue();

                    CurrentHPLabel.Invoke((MethodInvoker)delegate
                    {
                        CurrentHPLabel.Text = hp.ToString();
                    });
                    CurrentSPLabel.Invoke((MethodInvoker)delegate
                    {
                        CurrentSPLabel.Text = sp.ToString();
                    });
                    CurrentMoneyLabel.Invoke((MethodInvoker)delegate
                    {
                        CurrentMoneyLabel.Text = money.ToString();
                    });
                    
                    // Check for activated checkboxes; write current value if
                    // checked
                    if (LockHPCheckBox.Checked)
                    {
                        // Write value
                        CSHacking.WriteHP(hpToLock);
                    }
                    if (LockSPCheckBox.Checked)
                    {
                        // Write value
                        CSHacking.WriteSP(spToLock);
                    }
                    if (LockMoneyCheckBox.Checked)
                    {
                        // Write value
                        CSHacking.WriteMoney(moneyToLock);
                    }
                }
                else
                    ProcessStatusLabel.Invoke((MethodInvoker)delegate
                    {
                        ProcessStatusLabel.ForeColor = Color.DarkRed; 
                        ProcessStatusLabel.Text = "CLOSED";
                    });
            }            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void SavePosBtn_Click(object sender, EventArgs e)
        {
            UISavePlayerPos();
        }

        private void LoadPosBtn_Click(object sender, EventArgs e)
        {
            UILoadPlayerPos();
        }

        private void UISavePlayerPos()
        {
            if (CSHacking.CheckIfProcOpen())
            {
                // Get Player coordinates
                double[] playerPosition = CSHacking.ReadPlayerPOS();
                savedXPos = playerPosition[0];
                savedYPos = playerPosition[1];

                // Update UI
                SavedXPosTextBox.Text = playerPosition[0].ToString();
                SavedYPosTextBox.Text = playerPosition[1].ToString();
            }
            else
                MessageBox.Show("Cyber Shadow must be running to Save Coordinates.");

        }

        private void UILoadPlayerPos()
        {
            if (CSHacking.CheckIfProcOpen())
            {
                // Write current saved textbox data into memory

                // X data
                string xData = SavedXPosTextBox.Text;
                string yData = SavedYPosTextBox.Text;

                CSHacking.WritePlayerPOS(xData, yData);
            }
            else
                MessageBox.Show("Cyber Shadow must be running to Load Coordinates.");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
            UnregisterHotKey(this.Handle, 1);
        }

        private void UpdateHPBtn_Click(object sender, EventArgs e)
        {
            // Check Proc is running
            if (CSHacking.CheckIfProcOpen())
            {
                // Load Value from textbox into memory
                // TODO: Confirm that value in textbox is valid (a number)
                string hpValueToWrite = UpdateHPTextBox.Text;
                CSHacking.WriteHP(hpValueToWrite);
            }
        }

        private void UpdateSPBtn_Click(object sender, EventArgs e)
        {
            // Check Proc is running
            if (CSHacking.CheckIfProcOpen())
            {
                // Load Value from textbox into memory
                // TODO: Confirm that value in textbox is valid (a number)
                string spValueToWrite = UpdateSPTextBox.Text;
                CSHacking.WriteSP(spValueToWrite);
            }
        }

        private void UpdateMoneyBtn_Click(object sender, EventArgs e)
        {
            // Check Proc is running
            if (CSHacking.CheckIfProcOpen())
            {
                // Load Value from textbox into memory
                // TODO: Confirm that value in textbox is valid (a number)
                string moneyValueToWrite = UpdateMoneyTextBox.Text;
                CSHacking.WriteMoney(moneyValueToWrite);
            }
        }

        private void LockHPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LockHPCheckBox.Checked)
                hpToLock = CurrentHPLabel.Text;            
        }

        private void LockSPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LockSPCheckBox.Checked)
                spToLock = CurrentSPLabel.Text;
        }

        private void LockMoneyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LockMoneyCheckBox.Checked)
                moneyToLock = CurrentMoneyLabel.Text;
        }

        //private void LockHPCheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(CSHacking.CheckIfProcOpen() && LockHPCheckBox.Checked)
        //    {
        //        // Get current value
        //        string currentHP = CurrentHPLabel.Text;


        //    }
        //}
    }
}