using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BrainTimer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyicon.Visible = true;
                mynotifyicon.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                mynotifyicon.Visible = true;
            }
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

        private void ButtonFlasher_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ButtonStudy.Text = textBox1.Text;
        }
    }
}
