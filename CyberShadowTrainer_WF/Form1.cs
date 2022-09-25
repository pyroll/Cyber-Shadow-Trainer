using CSHacking;
using CyberShadowTrainer_WF.Models;
using Memory;
using System.Diagnostics;
using System.Web;

namespace CyberShadowTrainer_WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Populate Sub Wep ComboBox
            foreach (string sub in subWepCBArray)
            {
                SubWepComboBox.Items.Add(sub);
            }

            // Register Hotkeys
            int idF2 = 0; // The id of the hotkey F2
            int idF4 = 1; // The id of the hotkey F4
            RegisterHotKey(this.Handle, idF2, (int)KeyModifier.None, Keys.F2.GetHashCode());
            RegisterHotKey(this.Handle, idF4, (int)KeyModifier.None, Keys.F4.GetHashCode());
        }

        #region Props

        public Mem m = new Mem();
        public CSHackingClass CSHacking = new CSHackingClass();

        private string hpToLock;
        private string spToLock;
        private string moneyToLock;
        private string subWepToLock;
        private string subIDToLock;

        private string[] subWepCBArray = { "Blade Extend", "Swag Blade",
                                           "Charge Blaster", "E-Field", "SP Dispenser",
                                           "Ningun", "Orbiter", "Salvager", "none"};

        private SubWeapon[] subWepClasses = new SubWeapon[]
            {
                new SubWeapon("Blade Extend", "blade_extend", "12"),
                new SubWeapon("Swag Blade", "swag_blade", "10", "CyberShadow.exe+32CF51C,0x20,0x200"),
                new SubWeapon("Charge Blaster", "blaster", "7", "CyberShadow.exe+32CD398,0x20,0x1E0"),
                new SubWeapon("E-Field", "e_field", "7"),
                new SubWeapon("SP Dispenser", "sp_dispenser", "12", "CyberShadow.exe+32CAD9C,0x24,0x1C,0x20,0x1E0"),
                new SubWeapon("Ningun", "ningun", "6"),
                new SubWeapon("Orbiter", "orbiter", "7"),
                new SubWeapon("Salvager", "salvager", "8"),
                new SubWeapon("None", "none", "4")
            };

        // TODO: Remove unneeded?
        private Dictionary<string, string> subWepCBDictionary = new Dictionary<string, string>();

        #endregion

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
        // TODO: Remove unused?
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

                    // Read and Update Current Sub Weapon
                    string currentSubInMemory = CSHacking.ReadSubWepName();
                    // Get name to display in ComboBox
                    string currentSub = GetNameForSubLabel(currentSubInMemory);
                    CurrentSubLabel.Invoke((MethodInvoker)delegate
                    {
                        CurrentSubLabel.Text = currentSub;
                    });

                    // Check for activated checkboxes; write current value if
                    // checked

                    // Locking HP CheckBox
                    if (LockHPCheckBox.Checked)
                    {
                        // Write hp value
                        CSHacking.WriteHP(hpToLock);
                    }
                    if (LockSPCheckBox.Checked)
                    {
                        // Write sp value
                        CSHacking.WriteSP(spToLock);
                    }
                    if (LockMoneyCheckBox.Checked)
                    {
                        // Write money value
                        CSHacking.WriteMoney(moneyToLock);
                    }

                    // Locking Sub Weapon
                    if (LockSubWepCheckBox.Checked)
                    {
                        //SubWeapon subWep = GetCurrentSubWeapon();

                        // Write Sub Weapon into memory
                        //CSHacking.GiveSubWeapon(subWep.MemName, subWep.ID);
                        CSHacking.GiveSubWeapon(subWepToLock, subIDToLock);
                    }

                    // Locking Sub HP
                    if (LockSubHPCheckBox.Checked)
                    {
                        SubWeapon subWep = GetCurrentSubWeapon();

                        if (subWep.HPAddress != "Not Implemented")
                        {
                            // Write value
                            CSHacking.WriteSubHP(subWep.HPAddress, "3");
                        }
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

        // TODO: Remove?
        private SubWeapon[] CreateSubWepClasses()
        {
            SubWeapon[] subWepClasses = new SubWeapon[]
            {
                new SubWeapon("Blade Extend", "blade_extend", "12"),
                new SubWeapon("Swag Blade", "swag_blade", "10"),
                new SubWeapon("Charge Blaster", "blaster", "7"),
                new SubWeapon("E-Field", "e_field", "7"),
                new SubWeapon("Ningun", "ningun", "6"),
                new SubWeapon("Orbiter", "orbiter", "7"),
                new SubWeapon("Salvager", "salvager", "8"),
                new SubWeapon("None", "none", "4")
            };

            return subWepClasses;

            //SubWeapon bladeExtend = new SubWeapon("Blade Extend", "blade_extend", "12");
            //SubWeapon swagBlade = new SubWeapon("Swag Blade", "swag_blade", "10");
            //SubWeapon cBlaster = new SubWeapon("Charge Blaster", "blaster", "7");
            //SubWeapon eField = new SubWeapon("E-Field", "e_field", "7");
            //SubWeapon ningun = new SubWeapon("Ningun", "ningun", "6");
            //SubWeapon orbiter = new SubWeapon("Orbiter", "orbiter", "7");
            //SubWeapon salvager = new SubWeapon("Salvager", "salvager", "8");
            //SubWeapon noSub = new SubWeapon("None", "none", "4");            
        }

        private string GetNameForSubLabel(string sub)
        {
            switch (sub)
            {
                case "blade_extend":
                    return "Blade Extend";
                case "swag_blade":
                    return "Swag Blade";
                case "blaster":
                    return "Blaster";
                case "e_field":
                    return "E-Field";
                case "ningun":
                    return "Ningun";
                case "orbiter":
                    return "Orbiter";
                case "salvager":
                    return "Salvager";
                case "sp_dispenser":
                    return "SP Dispenser";
                case "none":
                    return "None";
            }

            return "Error";
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
                string xData = SavedXPosTextBox.Text;
                string yData = SavedYPosTextBox.Text;

                CSHacking.WritePlayerPOS(xData, yData);

                // Also write other values if checkbox is checked
                if (LoadWithValsCheckBox.Checked)
                {
                    CSHacking.WriteHP(HPLoadPosTextBox.Text);
                    CSHacking.WriteSP(SPLoadPosTextBox.Text);
                    CSHacking.WriteMoney(MoneyLoadPosTextBox.Text);
                }
            }
            else
                MessageBox.Show("Cyber Shadow must be running to Load Coordinates.");
        }

        // Unregister HotKeys on Close
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

        private void SetLoadValuesCurrentBtn_Click(object sender, EventArgs e)
        {
            HPLoadPosTextBox.Text = CurrentHPLabel.Text;
            SPLoadPosTextBox.Text = CurrentSPLabel.Text;
            MoneyLoadPosTextBox.Text = CurrentMoneyLabel.Text;
        }

        private SubWeapon GetCurrentSubWeapon()
        {
            // Read memory for current sub wep
            string currentSub = CSHacking.ReadSubWepName();

            foreach (SubWeapon sub in subWepClasses)
            {
                // TODO: this will return false since sub name in memory
                // isn't updated correctly
                if (currentSub == sub.MemName)
                {
                    return sub;
                }
            }

            return new SubWeapon("None", "none", "4");
        }

        private void UpdateSubBtn_Click(object sender, EventArgs e)
        {
            // Get selection from combobox
            if (SubWepComboBox.SelectedItem != null)
            {
                // Grab selected sub wep as string
                string selectedSub = SubWepComboBox.SelectedItem.ToString();

                // Find current Sub
                //foreach (SubWeapon sub in subWepClasses)
                //{
                //    if (sub.DisplayName == selectedSub)
                //    {

                //    }
                //}

                foreach (SubWeapon sub in subWepClasses)
                {
                    if (selectedSub == sub.DisplayName)
                    {
                        // Write sub name and id into memory
                        CSHacking.GiveSubWeapon(sub.MemName, sub.ID);
                        break;
                    }
                }
            }
        }

        private void LockSubWepCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LockSubWepCheckBox.Checked)
            {
                // Read Current Sub Weapon
                string currentSubInMemory = CSHacking.ReadSubWepName();
                string currentSubID = CSHacking.ReadSubWepID().ToString();
                
                subWepToLock = currentSubInMemory;
                subIDToLock = currentSubID;
            }
        }
    }
}