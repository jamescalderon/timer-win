using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    class taskbarTimer : ApplicationContext
    {
        NotifyIcon notifyIcon = new NotifyIcon();
        OptionsWindow optionsWindow = new OptionsWindow();

        /// <summary>
        /// Initializes a new instance of the <see cref="taskbarTimer"/> class.
        /// </summary>
        public taskbarTimer()
        {
            MenuItem configMenuItem = new MenuItem("Timer Options", new EventHandler(ShowConfig));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));
            MenuItem timerMenuItem = new MenuItem("Start Timer", new EventHandler(timer1));

            notifyIcon.Icon = Timer.Properties.Resources.clock_black;
            notifyIcon.DoubleClick += new EventHandler(ShowMessage);
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem, timerMenuItem}); //list of items in taskbar context as array
            notifyIcon.Visible = true;
        }

        void ShowMessage(object sender, EventArgs e)
        {
            // Only show the message if the settings say we can.
            //if (Timer.Properties.Settings.Default.ShowMessage)
            //    MessageBox.Show("Hello World");
        }

        void ShowConfig(object sender, EventArgs e)
        {
            // If we are already showing the window meerly focus it.
            if (optionsWindow.Visible)
                optionsWindow.Focus();
            else
                optionsWindow.ShowDialog();
        }

        void Exit(object sender, EventArgs e)
        {
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            notifyIcon.Visible = false;

            Application.Exit(); //exit for real
        }
        void timer1(object sender, EventArgs e)
        {
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            notifyIcon.Visible = false;

            Application.Exit(); //exit for real
        }
    }
}
