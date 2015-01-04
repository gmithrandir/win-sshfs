﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication2
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            Loglevel.SelectedIndex = 0;// Debugging ist beim Start der Form ausgewählt
        }
       
        private void Loglevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void virtualdriveletter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Utilities.GetAvailableDrives() schaut nach den verfügbaren drive letters 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to the URL.
            System.Diagnostics.Process.Start("https://github.com/thb42/win-sshfs");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
            RegisterInStartup(checkBox1.Checked);
        }

        //  start program at windows startup
        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("FiSSH", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("FiSSH");
            }
        }
    }
}