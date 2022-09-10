using CSHacking;
using Memory;

namespace CyberShadowTrainer_WF
{
    public partial class MainForm : Form
    {
        // TODO: Learn how to register/disable global hotkey for Save/Load Position
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

                //MessageBox.Show("Hotkey has been pressed!");
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
                SavedXPosLabel.Text = playerPosition[0].ToString();
                SavedYPosLabel.Text = playerPosition[1].ToString();
            }
            else
                MessageBox.Show("Cyber Shadow must be running to Save Coordinates.");

        }

        private void UILoadPlayerPos()
        {
            if (CSHacking.CheckIfProcOpen())
            {
                // Write saved pos into memory
                CSHacking.WritePlayerPOS(savedXPos.ToString(), savedYPos.ToString());
            }
            else
                MessageBox.Show("Cyber Shadow must be running to Load Coordinates.");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
            UnregisterHotKey(this.Handle, 1);
        }
    }
}