namespace BrainTimer
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
            this.ButtonAbort = new System.Windows.Forms.Button();
            this.Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItemFromMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Preferences_MinimizeWhenTimedFromMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Preferences_AlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.PrefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ButtonBreak = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxBreak = new System.Windows.Forms.TextBox();
            this.ButtonStudy = new System.Windows.Forms.Button();
            this.GroupBoxStudy = new System.Windows.Forms.GroupBox();
            this.TextBoxStudy = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MenuStrip.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBoxStudy.SuspendLayout();
            this.SuspendLayout();
            // 
            // mynotifyicon
            // 
            this.mynotifyicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mynotifyicon.BalloonTipTitle = "BrainTimer";
            this.mynotifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("mynotifyicon.Icon")));
            this.mynotifyicon.Text = "BrainTimer";
            this.mynotifyicon.Visible = true;
            this.mynotifyicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // ButtonAbort
            // 
            this.ButtonAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAbort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAbort.Location = new System.Drawing.Point(12, 271);
            this.ButtonAbort.Name = "ButtonAbort";
            this.ButtonAbort.Size = new System.Drawing.Size(156, 35);
            this.ButtonAbort.TabIndex = 29;
            this.ButtonAbort.Text = "Reset";
            this.ButtonAbort.UseVisualStyleBackColor = true;
            // 
            // Help_About
            // 
            this.Help_About.Name = "Help_About";
            this.Help_About.Size = new System.Drawing.Size(115, 22);
            this.Help_About.Text = "&About";
            // 
            // HelpToolStripMenuItemFromMenuStrip
            // 
            this.HelpToolStripMenuItemFromMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help_About});
            this.HelpToolStripMenuItemFromMenuStrip.Name = "HelpToolStripMenuItemFromMenuStrip";
            this.HelpToolStripMenuItemFromMenuStrip.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItemFromMenuStrip.Text = "Help";
            // 
            // SaveToolStripMenuItem1
            // 
            this.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1";
            this.SaveToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.SaveToolStripMenuItem1.Text = "Save";
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
            this.PrefToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Preferences_AlwaysOnTop,
            this.Preferences_MinimizeWhenTimedFromMenuStrip,
            this.ToolStripSeparator6,
            this.SaveToolStripMenuItem1});
            this.PrefToolStripMenuItem.Name = "PrefToolStripMenuItem";
            this.PrefToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.PrefToolStripMenuItem.Text = "Preferences";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrefToolStripMenuItem,
            this.HelpToolStripMenuItemFromMenuStrip});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(182, 24);
            this.MenuStrip.TabIndex = 33;
            this.MenuStrip.Text = "MenuStrip1";
            // 
            // ButtonBreak
            // 
            this.ButtonBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBreak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonBreak.Location = new System.Drawing.Point(9, 43);
            this.ButtonBreak.Name = "ButtonBreak";
            this.ButtonBreak.Size = new System.Drawing.Size(60, 60);
            this.ButtonBreak.TabIndex = 15;
            this.ButtonBreak.Text = "Break";
            this.ButtonBreak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonBreak.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ButtonBreak);
            this.GroupBox1.Controls.Add(this.TextBoxBreak);
            this.GroupBox1.Location = new System.Drawing.Point(93, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(75, 118);
            this.GroupBox1.TabIndex = 32;
            this.GroupBox1.TabStop = false;
            // 
            // TextBoxBreak
            // 
            this.TextBoxBreak.Location = new System.Drawing.Point(9, 17);
            this.TextBoxBreak.Name = "TextBoxBreak";
            this.TextBoxBreak.Size = new System.Drawing.Size(60, 20);
            this.TextBoxBreak.TabIndex = 17;
            this.TextBoxBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonStudy
            // 
            this.ButtonStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStudy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonStudy.Location = new System.Drawing.Point(9, 43);
            this.ButtonStudy.Name = "ButtonStudy";
            this.ButtonStudy.Size = new System.Drawing.Size(60, 60);
            this.ButtonStudy.TabIndex = 22;
            this.ButtonStudy.Text = "Study";
            this.ButtonStudy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonStudy.UseVisualStyleBackColor = true;
            // 
            // GroupBoxStudy
            // 
            this.GroupBoxStudy.Controls.Add(this.textBox1);
            this.GroupBoxStudy.Controls.Add(this.TextBoxStudy);
            this.GroupBoxStudy.Controls.Add(this.ButtonStudy);
            this.GroupBoxStudy.Location = new System.Drawing.Point(12, 9);
            this.GroupBoxStudy.Name = "GroupBoxStudy";
            this.GroupBoxStudy.Size = new System.Drawing.Size(75, 220);
            this.GroupBoxStudy.TabIndex = 31;
            this.GroupBoxStudy.TabStop = false;
            // 
            // TextBoxStudy
            // 
            this.TextBoxStudy.Location = new System.Drawing.Point(9, 17);
            this.TextBoxStudy.Name = "TextBoxStudy";
            this.TextBoxStudy.Size = new System.Drawing.Size(60, 20);
            this.TextBoxStudy.TabIndex = 16;
            this.TextBoxStudy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 335);
            this.Controls.Add(this.ButtonAbort);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBoxStudy);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Timer";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBoxStudy.ResumeLayout(false);
            this.GroupBoxStudy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon mynotifyicon;
        internal System.Windows.Forms.Button ButtonAbort;
        internal System.Windows.Forms.ToolStripMenuItem Help_About;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItemFromMenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripMenuItem Preferences_MinimizeWhenTimedFromMenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem Preferences_AlwaysOnTop;
        internal System.Windows.Forms.ToolStripMenuItem PrefToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip MenuStrip;
        internal System.Windows.Forms.Button ButtonBreak;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TextBoxBreak;
        internal System.Windows.Forms.Button ButtonStudy;
        internal System.Windows.Forms.GroupBox GroupBoxStudy;
        internal System.Windows.Forms.TextBox TextBoxStudy;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.TextBox textBox1;
    }
}