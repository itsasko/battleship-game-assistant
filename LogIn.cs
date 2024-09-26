using System;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonSumbit1_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text != "user" || textBoxPassword.Text != "password")
            {
                if (textBoxUserName.Text != "user")
                {
                    MessageBox.Show("The username does not exist. Do you want to sign in?");
                    // should suggest to sign in, because the user with this username does not exist
                }
                labelError.Visible = true;
            }
            else
            {
                Menu f = new Menu();
                f.Show();
                f.Tag = "1";
                Hide();
            }

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }
    }
}
