using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SimpleCPUAnalysis
{
    public partial class Form1 : Form
    {
        #region Dll Imports
        //Import the necessarry functions

        //Function to make window draggable
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //Function to make window draggable
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        //Function to get key states
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        //Function for mouse moving events
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData,
        int dwExtraInfo);

        //[DllImport("user32.dll")]   Alternative option for mouse_event
        // public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        //Some constants used in mouse_event

        public const uint MOUSEEVENTF_MOVE = 0x0001;
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        #endregion

        public int keybind;
        public int sleep;
        public int speed;
        public int SpeedSelectedIndex;
        bool runit = false;
        bool rmbdown = false;
        SoundPlayer on = new SoundPlayer("on.wav");
        SoundPlayer off = new SoundPlayer("off.wav");
        SoundPlayer one = new SoundPlayer("onespeed.wav");
        SoundPlayer two = new SoundPlayer("twospeed.wav");
        SoundPlayer three = new SoundPlayer("threespeed.wav");
        SoundPlayer four = new SoundPlayer("fourspeed.wav");
        SoundPlayer five = new SoundPlayer("fivespeed.wav");

        public Form1()
        {
            InitializeComponent();
        }


        // On form load, load up the previous options and start the background workers
        private void Form1_Load(object sender, EventArgs e)
        {
            ddmSpeed.selectedIndex = Properties.Settings.Default.Speed;
            ddmSleep.selectedIndex = Properties.Settings.Default.Sleep;
            ddmKeybind.selectedIndex = Properties.Settings.Default.Keybind;
            bgwPause.RunWorkerAsync();
            bgwSpeedCheck.RunWorkerAsync();
        }

        // On Run_Checkbox change event, start/cancel the background worker, and update our runit bool
        private void ckbRun_OnChange(object sender, EventArgs e)
        {
            if (ckbRun.Checked && ddmSpeed.selectedIndex != -1 && ddmSleep.selectedIndex != -1 && ddmKeybind.selectedIndex != -1)
            {
                bgwRun.RunWorkerAsync();
                bunifuCustomLabel8.ForeColor = Color.Green;
                runit = true;
                on.Play();
            }

            else if (!ckbRun.Checked)
            {
                if (bgwRun.IsBusy)
                {
                    bgwRun.CancelAsync();
                    bunifuCustomLabel8.ForeColor = Color.White;
                    runit = false;
                    off.Play();
                }
            }
        }

        //Just messing around with playing sound files
        public void PlaySounds(int i)
        {
            switch (i)
            {
                case (0):
                    one.Play();
                    break;
                case (1):
                    two.Play();
                    break;
                case (2):
                    three.Play();
                    break;
                case (3):
                    four.Play();
                    break;
                case (4):
                    five.Play();
                    break;
            }
        }

        //Function to move the mouse down (control recoil)
        private void bgwRun_DoWork(object sender, DoWorkEventArgs e)
        {
            bgwRun.WorkerSupportsCancellation = true;
            while (!bgwRun.CancellationPending)
            {

                speed = int.Parse(ddmSpeed.selectedValue);
                SpeedSelectedIndex = ddmSpeed.selectedIndex;

                if (rmbdown)
                {
                    //checks if key and right click are pressed
                    if (GetAsyncKeyState(keybind) != 0 && GetAsyncKeyState(0x02) != 0 && runit)
                    {
                        mouse_event(MOUSEEVENTF_MOVE, 0, (speed), 0, 0);
                    }
                    Thread.Sleep((25 * sleep));
                }
                else
                {
                    //checks for only the key specified
                    if (GetAsyncKeyState(keybind) != 0 && runit)
                    {
                        mouse_event(MOUSEEVENTF_MOVE, 0, (speed), 0, 0);
                    }
                    Thread.Sleep((25 * sleep));
                }
                Thread.Sleep(5);
            }
        }

        //Check for "End" key being pressed to resume
        private void bgwPause_DoWork(object sender, DoWorkEventArgs e)
        {
            bgwPause.WorkerSupportsCancellation = true;
            while (!bgwPause.CancellationPending)
            {
                if (GetAsyncKeyState(0x23) == -32767)
                {
                    runit = !runit;
                    if (runit)
                    {
                        ckbRun.Checked = true;
                        ckbRun_OnChange(sender, e);
                    }
                    if (!runit)
                    {
                        ckbRun.Checked = false;
                        ckbRun_OnChange(sender, e);
                    }
                }
                Thread.Sleep(15);
            }
        }

        /// <summary>
        /// Checks + and - keys and adjusts speed accordingly.
        /// Numpad + increases speed (or loops to 1 if already at top speed)
        /// Numpad - decreases speed (or loops to 5 if already at 1)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwSpeedCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                //Check if + key was pressed
                if (GetAsyncKeyState(0x6B) == -32767)
                {
                    //If speed == max speed, speed = 0 (min)
                    if (SpeedSelectedIndex == 4)
                    {
                        SpeedSelectedIndex = 0;
                        ddmSpeed.selectedIndex = SpeedSelectedIndex;
                        PlaySounds(SpeedSelectedIndex);
                    }

                    //Else increment speed
                    else
                    {
                        SpeedSelectedIndex++;
                        ddmSpeed.selectedIndex = SpeedSelectedIndex;
                        PlaySounds(SpeedSelectedIndex);
                    }
                }

                Thread.Sleep(5);
                //Check if - key was pressed
                if (GetAsyncKeyState(0x6D) == -32767)
                {
                    //If speed == min speed, speed = 4 (max)
                    if (SpeedSelectedIndex == 0)
                    {
                        SpeedSelectedIndex = 4;
                        ddmSpeed.selectedIndex = SpeedSelectedIndex;
                        PlaySounds(SpeedSelectedIndex);
                    }

                    //Else decrement speed
                    else
                    {
                        SpeedSelectedIndex--;
                        ddmSpeed.selectedIndex = SpeedSelectedIndex;
                        PlaySounds(SpeedSelectedIndex);
                    }
                }
                Thread.Sleep(15);
            }
        }

        /// <summary>
        /// Switch the sleep time based on the new selected index from the dropdown menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddmSleep_onItemSelected(object sender, EventArgs e)
        {
            //I was learning dropdownmenus and switch statements, I realize you can just do selectedIndex + 1
            switch (ddmSleep.selectedIndex)
            {
                case (0):
                    sleep = 1;
                    break;
                case (1):
                    sleep = 2;
                    break;
                case (2):
                    sleep = 3;
                    break;
                case (3):
                    sleep = 4;
                    break;
            }
        }

        /// <summary>
        /// Set the keybind to the appropriate virtual key code based on selected item from dropdownmenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddmKeybind_onItemSelected(object sender, EventArgs e)
        {
            switch (ddmKeybind.selectedIndex)
            {
                //cf https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
                case 0:
                    keybind = 0x01;
                    break;
                case 1:
                    keybind = 0x02;
                    break;
                case 2:
                    keybind = 0x12;
                    break;
                case 3:
                    keybind = 0x11;
                    break;
            }
        }

        //On the Right Click checkbox change, set the value for rmbdown
        private void ckbxWaitRightClick_OnChange(object sender, EventArgs e)
        {
            rmbdown = (ckbxWaitRightClick.Checked) ? true : false;
        }

        //Saves current settings to our properties file
        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Speed = ddmSpeed.selectedIndex;
            Properties.Settings.Default.Sleep = ddmSleep.selectedIndex;
            Properties.Settings.Default.Keybind = ddmKeybind.selectedIndex;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        //makes the form draggable
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bunifuCustomLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //makes the form draggable
        private void bunifuCustomLabel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //Some little nicities to change the color of the minimize and exit buttons
        private void bunifuCustomLabel5_MouseEnter(object sender, EventArgs e)
        {
            bunifuCustomLabel5.BackColor = Color.White;
        }

        private void bunifuCustomLabel5_MouseLeave(object sender, EventArgs e)
        {
            bunifuCustomLabel5.BackColor = Color.FromArgb(80, 81, 96);
        }

        private void bunifuCustomLabel6_MouseEnter(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.White;
        }

        private void bunifuCustomLabel6_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.FromArgb(80, 81, 96);
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}