using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Player1 : Form
    {
        bool isGameStarted = false;
        private Button[] playerButtons = new Button[100];
        private Button[] opponentButtons = new Button[100];
        private char[] columnLabels = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        public Player1()
        {
            InitializeComponent();
            CreatePlayerButtons();
            CreateOpponentButtons();
            MessageBox.Show("Locate carrier (occupies 5 spaces)");
            MessageBox.Show("Locate battleship (occupies 4 spaces)");
            MessageBox.Show("Locate cruiser (occupies 3 spaces)");
            MessageBox.Show("Locate submarine (occupies 3 spaces)");
            MessageBox.Show("Locate destroyer (occupies 2 spaces)");

        }
        private void CreatePlayerButtons()
        {
            for (int i = 0; i < 100; i++)
            {
                int row = i / 10 + 1;
                char column = columnLabels[i % 10];
                this.playerButtons[i] = new Button();
                this.playerButtons[i].Location = new Point((i % 10) * 90, (i / 10) * 90);
                this.playerButtons[i].Size = new Size(90, 90);
                this.playerButtons[i].TabIndex = i + 10;
                this.playerButtons[i].Text = $"{row}{column}";
                this.playerButtons[i].UseVisualStyleBackColor = true;
                this.playerButtons[i].BackColor = Color.White;
                this.playerButtons[i].Click += new System.EventHandler(this.PlayerButtonClick);
                this.tabPage1.Controls.Add(this.playerButtons[i]); 
            }
        }

        private void CreateOpponentButtons()
        {
            for (int i = 0; i < 100; i++)
            {
                int row = i / 10 + 1;
                char column = columnLabels[i % 10];
                this.opponentButtons[i] = new Button();
                this.opponentButtons[i].Location = new Point((i % 10) * 90, (i / 10) * 90);
                this.opponentButtons[i].Size = new Size(90, 90);
                this.opponentButtons[i].TabIndex = i + 110;
                this.opponentButtons[i].Text = $"{row}{column}";
                this.opponentButtons[i].UseVisualStyleBackColor = true;
                this.playerButtons[i].BackColor = Color.White;
                this.playerButtons[i].Click += new System.EventHandler(this.OpponentButtonClick);
                this.tabPage2.Controls.Add(this.opponentButtons[i]);
            }
        }
        private void PlayerButtonClick(object sender, EventArgs e)
        {
            if (!isGameStarted)
            {
                Button clickedButton = sender as Button;
                if (clickedButton.BackColor == Color.White)
                {
                    clickedButton.BackColor = Color.Blue;
                }
                else
                {
                    clickedButton.BackColor = Color.White;
                }
            }
        }
        private void OpponentButtonClick(object sender, EventArgs e)
        {
            if (isGameStarted)
            {
                Button clickedButton = sender as Button;
                if (clickedButton.BackColor == Color.White)
                {
                    clickedButton.BackColor = Color.Red;
                }
                else
                {
                    clickedButton.BackColor = Color.White;
                }
            }
            
        }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
    }
}

