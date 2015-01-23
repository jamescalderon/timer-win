using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainWindow : Form

       
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainWindow wndw = new MainWindow(); 
            wndw.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton"))
            {

            }
            else
            {
                // Then assume that X has been clicked and act accordingly.
                MessageBox.Show("Test");
            }
        }

        

        

        private void TimerMain_Tick(object sender, EventArgs e)
        {

        }

        private void minimizeOnTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void MainWindow_SizeChanged(object sender, EventArgs e) //minimize/maximize form
        //{
        //    if (this.WindowState == FormWindowState.Minimized)
        //    {
        //        //mynotifyicon.Icon = BrainTimer.Properties.Resources.clock_black;
        //    }
        //}

        private void MainWindow_Load(object sender, EventArgs e)
        {
            mynotifyicon.Icon = Timer.Properties.Resources.clock_black;
        }

        private void MenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
