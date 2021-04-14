namespace SimpleCPUAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ckbRun = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bgwRun = new System.ComponentModel.BackgroundWorker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ddmSpeed = new Bunifu.Framework.UI.BunifuDropdown();
            this.ddmKeybind = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bgwPause = new System.ComponentModel.BackgroundWorker();
            this.lblMinimize = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ddmSleep = new Bunifu.Framework.UI.BunifuDropdown();
            this.ckbxWaitRightClick = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bgwSpeedCheck = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ckbRun
            // 
            this.ckbRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckbRun.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckbRun.Checked = false;
            this.ckbRun.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckbRun.ForeColor = System.Drawing.Color.White;
            this.ckbRun.Location = new System.Drawing.Point(41, 207);
            this.ckbRun.Name = "ckbRun";
            this.ckbRun.Size = new System.Drawing.Size(20, 20);
            this.ckbRun.TabIndex = 0;
            this.ckbRun.OnChange += new System.EventHandler(this.ckbRun_OnChange);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(69, 168);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(148, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Wait For Right Click";
            this.bunifuCustomLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomLabel1_MouseDown);
            // 
            // bgwRun
            // 
            this.bgwRun.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRun_DoWork);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(37, 42);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(60, 20);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Speed:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(37, 6);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(178, 24);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Simple Recoil Script";
            this.bunifuCustomLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomLabel3_MouseDown);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(37, 126);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 20);
            this.bunifuCustomLabel4.TabIndex = 1;
            this.bunifuCustomLabel4.Text = "Keybind:";
            // 
            // ddmSpeed
            // 
            this.ddmSpeed.BackColor = System.Drawing.Color.Transparent;
            this.ddmSpeed.BorderRadius = 3;
            this.ddmSpeed.DisabledColor = System.Drawing.Color.Gray;
            this.ddmSpeed.ForeColor = System.Drawing.Color.White;
            this.ddmSpeed.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5"};
            this.ddmSpeed.Location = new System.Drawing.Point(113, 42);
            this.ddmSpeed.Name = "ddmSpeed";
            this.ddmSpeed.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddmSpeed.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddmSpeed.selectedIndex = -1;
            this.ddmSpeed.Size = new System.Drawing.Size(102, 22);
            this.ddmSpeed.TabIndex = 2;
            // 
            // ddmKeybind
            // 
            this.ddmKeybind.BackColor = System.Drawing.Color.Transparent;
            this.ddmKeybind.BorderRadius = 3;
            this.ddmKeybind.DisabledColor = System.Drawing.Color.Gray;
            this.ddmKeybind.ForeColor = System.Drawing.Color.White;
            this.ddmKeybind.Items = new string[] {
        "L Click",
        "R Click",
        "L Alt",
        "L Control"};
            this.ddmKeybind.Location = new System.Drawing.Point(113, 126);
            this.ddmKeybind.Name = "ddmKeybind";
            this.ddmKeybind.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddmKeybind.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddmKeybind.selectedIndex = -1;
            this.ddmKeybind.Size = new System.Drawing.Size(102, 22);
            this.ddmKeybind.TabIndex = 2;
            this.ddmKeybind.onItemSelected += new System.EventHandler(this.ddmKeybind_onItemSelected);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(243, -5);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(20, 24);
            this.bunifuCustomLabel5.TabIndex = 1;
            this.bunifuCustomLabel5.Text = "x";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            this.bunifuCustomLabel5.MouseEnter += new System.EventHandler(this.bunifuCustomLabel5_MouseEnter);
            this.bunifuCustomLabel5.MouseLeave += new System.EventHandler(this.bunifuCustomLabel5_MouseLeave);
            // 
            // bgwPause
            // 
            this.bgwPause.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwPause_DoWork);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Red;
            this.lblMinimize.Location = new System.Drawing.Point(222, -10);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(21, 29);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "-";
            this.lblMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.bunifuCustomLabel6_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.bunifuCustomLabel6_MouseLeave);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(37, 84);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(54, 20);
            this.bunifuCustomLabel7.TabIndex = 1;
            this.bunifuCustomLabel7.Text = "Sleep:";
            // 
            // ddmSleep
            // 
            this.ddmSleep.BackColor = System.Drawing.Color.Transparent;
            this.ddmSleep.BorderRadius = 3;
            this.ddmSleep.DisabledColor = System.Drawing.Color.Gray;
            this.ddmSleep.ForeColor = System.Drawing.Color.White;
            this.ddmSleep.Items = new string[] {
        "1",
        "2",
        "3",
        "4"};
            this.ddmSleep.Location = new System.Drawing.Point(113, 84);
            this.ddmSleep.Name = "ddmSleep";
            this.ddmSleep.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddmSleep.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(158)))));
            this.ddmSleep.selectedIndex = -1;
            this.ddmSleep.Size = new System.Drawing.Size(102, 22);
            this.ddmSleep.TabIndex = 2;
            this.ddmSleep.onItemSelected += new System.EventHandler(this.ddmSleep_onItemSelected);
            // 
            // ckbxWaitRightClick
            // 
            this.ckbxWaitRightClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckbxWaitRightClick.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckbxWaitRightClick.Checked = false;
            this.ckbxWaitRightClick.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckbxWaitRightClick.ForeColor = System.Drawing.Color.White;
            this.ckbxWaitRightClick.Location = new System.Drawing.Point(41, 168);
            this.ckbxWaitRightClick.Name = "ckbxWaitRightClick";
            this.ckbxWaitRightClick.Size = new System.Drawing.Size(20, 20);
            this.ckbxWaitRightClick.TabIndex = 0;
            this.ckbxWaitRightClick.OnChange += new System.EventHandler(this.ckbxWaitRightClick_OnChange);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(69, 207);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(132, 20);
            this.bunifuCustomLabel8.TabIndex = 1;
            this.bunifuCustomLabel8.Text = "Run Recoil Script";
            this.bunifuCustomLabel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomLabel1_MouseDown);
            // 
            // bgwSpeedCheck
            // 
            this.bgwSpeedCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSpeedCheck_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(261, 237);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.ddmKeybind);
            this.Controls.Add(this.ddmSleep);
            this.Controls.Add(this.ddmSpeed);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ckbxWaitRightClick);
            this.Controls.Add(this.ckbRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple CPU Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox ckbRun;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.ComponentModel.BackgroundWorker bgwRun;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDropdown ddmSpeed;
        private Bunifu.Framework.UI.BunifuDropdown ddmKeybind;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.ComponentModel.BackgroundWorker bgwPause;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMinimize;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuDropdown ddmSleep;
        private Bunifu.Framework.UI.BunifuCheckbox ckbxWaitRightClick;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.ComponentModel.BackgroundWorker bgwSpeedCheck;
    }
}

