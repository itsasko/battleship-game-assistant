﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (Tag as string == "0" )
            {
                MessageBox.Show("Log in firstly!");
                Hide();
                Form logIn = new LogIn();
                logIn.Show();
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Hide();
            Form logIn = new LogIn();
            logIn.Show(); 
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            Form rules = new Rules();
            rules.Show();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {

        }
    }
}
