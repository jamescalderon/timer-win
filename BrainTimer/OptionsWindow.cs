using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class OptionsWindow : Form
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            //showMessageCheckBox.Checked = Timer.Properties.Settings.Default.ShowMessage;
        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            // If the user clicked "Save"
            if (this.DialogResult == DialogResult.OK)
            {
                //Timer.Properties.Settings.Default.ShowMessage = showMessageCheckBox.Checked;
                //Timer.Properties.Settings.Default.Save();
            }
        }

       
    }
}