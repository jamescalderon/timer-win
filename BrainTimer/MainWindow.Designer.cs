namespace Timer
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mynotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItemFromMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Preferences_MinimizeWhenTimedFromMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Preferences_AlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.PrefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeOnTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonBreak = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.MenuStrip.SuspendLayout();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // mynotifyicon
            // 
            this.mynotifyicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mynotifyicon.BalloonTipTitle = "Timer";
            this.mynotifyicon.Text = "Timer";
            this.mynotifyicon.Visible = true;
            this.mynotifyicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Help_About
            // 
            this.Help_About.Name = "Help_About";
            this.Help_About.Size = new System.Drawing.Size(152, 22);
            this.Help_About.Text = "&About";
            // 
            // HelpToolStripMenuItemFromMenuStrip
            // 
            this.HelpToolStripMenuItemFromMenuStrip.Name = "HelpToolStripMenuItemFromMenuStrip";
            this.HelpToolStripMenuItemFromMenuStrip.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItemFromMenuStrip.Text = "Help";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(191, 6);
            // 
            // Preferences_MinimizeWhenTimedFromMenuStrip
            // 
            this.Preferences_MinimizeWhenTimedFromMenuStrip.Name = "Preferences_MinimizeWhenTimedFromMenuStrip";
            this.Preferences_MinimizeWhenTimedFromMenuStrip.Size = new System.Drawing.Size(194, 22);
            this.Preferences_MinimizeWhenTimedFromMenuStrip.Text = "&Minimize When Timed";
            // 
            // Preferences_AlwaysOnTop
            // 
            this.Preferences_AlwaysOnTop.Name = "Preferences_AlwaysOnTop";
            this.Preferences_AlwaysOnTop.Size = new System.Drawing.Size(194, 22);
            this.Preferences_AlwaysOnTop.Text = "Always &On Top";
            // 
            // PrefToolStripMenuItem
            // 
            this.PrefToolStripMenuItem.Name = "PrefToolStripMenuItem";
            this.PrefToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.PrefToolStripMenuItem.Text = "Preferences";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(234, 24);
            this.MenuStrip.TabIndex = 33;
            this.MenuStrip.Text = "MenuStrip1";
            this.MenuStrip.Click += new System.EventHandler(this.MenuStrip_Click);
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.minimizeOnTimerToolStripMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem.Text = "Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            // 
            // minimizeOnTimerToolStripMenuItem
            // 
            this.minimizeOnTimerToolStripMenuItem.Name = "minimizeOnTimerToolStripMenuItem";
            this.minimizeOnTimerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.minimizeOnTimerToolStripMenuItem.Text = "Minimize On Timer";
            this.minimizeOnTimerToolStripMenuItem.Click += new System.EventHandler(this.minimizeOnTimerToolStripMenuItem_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, -7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(156, 13);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "Enter Minutes:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerMain
            // 
            this.TimerMain.Enabled = true;
            this.TimerMain.Interval = 1000;
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLeft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonLeft.Location = new System.Drawing.Point(15, 27);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(100, 100);
            this.ButtonLeft.TabIndex = 22;
            this.ButtonLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonLeft.UseVisualStyleBackColor = true;
            // 
            // ButtonBreak
            // 
            this.ButtonBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBreak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonBreak.Location = new System.Drawing.Point(212, 40);
            this.ButtonBreak.Name = "ButtonBreak";
            this.ButtonBreak.Size = new System.Drawing.Size(60, 60);
            this.ButtonBreak.TabIndex = 15;
            this.ButtonBreak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonBreak.UseVisualStyleBackColor = true;
            // 
            // ButtonOne
            // 
            this.ButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOne.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonOne.Location = new System.Drawing.Point(15, 27);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(100, 100);
            this.ButtonOne.TabIndex = 22;
            this.ButtonOne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonOne.UseVisualStyleBackColor = true;
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(10, 40);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(100, 100);
            this.buttonL.TabIndex = 34;
            this.buttonL.UseVisualStyleBackColor = true;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(120, 40);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(100, 100);
            this.buttonR.TabIndex = 35;
            this.buttonR.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(161, 76);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 152);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.contextMenuStripNotifyIcon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon mynotifyicon;
        internal System.Windows.Forms.ToolStripMenuItem Help_About;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItemFromMenuStrip;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripMenuItem Preferences_MinimizeWhenTimedFromMenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem Preferences_AlwaysOnTop;
        internal System.Windows.Forms.ToolStripMenuItem PrefToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip MenuStrip;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Timer TimerMain;
        internal System.Windows.Forms.Button ButtonLeft;
        internal System.Windows.Forms.Button ButtonBreak;
        internal System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeOnTimerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}