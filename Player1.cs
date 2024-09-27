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
        int shipBuilding = 5, i = 1;
        int sellCounter = 0;
        bool isHorisontalVertical = false;
        Point prev;
        private Button[] playerButtons = new Button[100];
        private Button[] opponentButtons = new Button[100];
        private char[] columnLabels = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        private string[] colorsLabels = { "Red", "Pink", "White" };
        public Player1()
        {
            InitializeComponent();
            CreatePlayerButtons();
            CreateOpponentButtons();
            MessageBox.Show("Locate carrier (occupies 5 spaces)");

        }
        private void CreatePlayerButtons()
        {
            for (int i = 0; i < 100; i++)
            {
                int row_ = i / 10, col_ = i % 10;
                int row = i / 10 + 1;
                char column = columnLabels[i % 10];
                this.playerButtons[i] = new Button();
                this.playerButtons[i].Location = new Point((i % 10) * 90, (i / 10) * 90);
                this.playerButtons[i].Size = new Size(90, 90);
                this.playerButtons[i].TabIndex = i + 10;
                this.playerButtons[i].Text = $"{row}{column}";
                this.playerButtons[i].UseVisualStyleBackColor = true;
                this.playerButtons[i].BackColor = Color.White;
                this.playerButtons[i].Tag = $"row_ col_";
                this.playerButtons[i].Click += new System.EventHandler(this.PlayerButtonClick);
                this.tabPage1.Controls.Add(this.playerButtons[i]); 
            }
        }

        private void CreateOpponentButtons()
        {
            for (int i = 0; i < 100; i++)
            {
                int row_ = i / 10, col_ = i % 10;
                int row = i / 10 + 1;
                char column = columnLabels[i % 10];
                this.opponentButtons[i] = new Button();
                this.opponentButtons[i].Location = new Point((i % 10) * 90, (i / 10) * 90);
                this.opponentButtons[i].Size = new Size(90, 90);
                this.opponentButtons[i].TabIndex = i + 110;
                this.opponentButtons[i].Text = $"{row}{column}";
                this.opponentButtons[i].UseVisualStyleBackColor = true;
                this.opponentButtons[i].BackColor = Color.White;
                this.opponentButtons[i].Tag = $"row_ col_";
                this.opponentButtons[i].Click += new System.EventHandler(this.OpponentButtonClick);
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
                    sellCounter += 1;
                    if(sellCounter == 1)
                    {
                        if (((clickedButton.Location.X - prev.X == 90 || clickedButton.Location.X - prev.X == -90) ^
                            (clickedButton.Location.Y - prev.Y == 90 || clickedButton.Location.Y - prev.Y == -90)) && shipBuilding != 5)
                        {
                            MessageBox.Show("Choose another sell!");
                            clickedButton.BackColor = Color.White;
                            sellCounter -= 1;
                        }
                        prev = clickedButton.Location;

                    }
                    if(sellCounter > 1 && sellCounter <= shipBuilding)
                    {
                        if ((clickedButton.Location.X - prev.X == 90 || clickedButton.Location.X - prev.X == -90) ^
                            (clickedButton.Location.Y - prev.Y == 90 || clickedButton.Location.Y - prev.Y == -90))
                        {
                            if(clickedButton.Location.X - prev.X == 90 || clickedButton.Location.X - prev.X == -90)
                            {
                                if(sellCounter == 2)
                                {
                                    isHorisontalVertical = true;
                                    prev = clickedButton.Location;
                                }
                                else
                                {
                                    if (!isHorisontalVertical)
                                    {
                                        MessageBox.Show("Choose the adjacent sell!");
                                        clickedButton.BackColor = Color.White;
                                        sellCounter -= 1;
                                    }
                                    else
                                    {
                                        prev = clickedButton.Location;
                                    }
                                }
                                    
                            }                            
                            if(clickedButton.Location.Y - prev.Y == 90 || clickedButton.Location.Y - prev.Y == -90)
                            {
                                if (sellCounter == 2)
                                {
                                    isHorisontalVertical = false;
                                    prev = clickedButton.Location;
                                }
                                else
                                {
                                    if (isHorisontalVertical)
                                    {
                                        MessageBox.Show("Choose the adjacent sell!");
                                        clickedButton.BackColor = Color.White;
                                        sellCounter -= 1;
                                    }
                                    else
                                    {
                                        prev = clickedButton.Location;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Choose the adjacent sell!");
                            clickedButton.BackColor = Color.White;
                            sellCounter -= 1;
                        }
                    }
                    if(sellCounter == shipBuilding)
                    {
                        sellCounter = 0;
                        prev = new Point(0, 0);
                        if (!(shipBuilding == 3) || i == 3)
                        {
                            shipBuilding -= 1;
                        }   
                        if (shipBuilding == 4)
                        {
                            MessageBox.Show("Locate battleship (occupies 4 spaces)");
                        }                        
                        if(shipBuilding == 3)
                        {
                            if (i == 1)
                            {
                                MessageBox.Show("Locate cruiser (occupies 3 spaces)");
                            }
                            if(i == 2)
                            {
                                MessageBox.Show("Locate submarine (occupies 3 spaces)");
                            }
                            i += 1;
                        }                                              
                        if(shipBuilding == 2)
                        {
                            MessageBox.Show("Locate destroyer (occupies 2 spaces)");
                        }
                        if (shipBuilding == 1)
                        {
                            isGameStarted = true;
                            MessageBox.Show("Start the game");
                        }
                        
                    }
                }
                else
                {
                    clickedButton.BackColor = Color.White;
                    sellCounter -= 1;
                }
            }
            if (isGameStarted)
            {
                if (tabControlPlayer1.SelectedTab == tabPage1)
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
            }
        }
        private void OpponentButtonClick(object sender, EventArgs e)
        {
            if (tabControlPlayer1.SelectedTab == tabPage2)
            {
                if (isGameStarted)
                {
                    Button clickedButton = sender as Button;
                    if (clickedButton.BackColor == Color.White)
                    {
                        clickedButton.BackColor = Color.Red;
                    }
                    else if (clickedButton.BackColor == Color.Red)
                    {
                        clickedButton.BackColor = Color.Pink;
                    }
                    else if (clickedButton.BackColor == Color.Pink)
                    {
                        clickedButton.BackColor = Color.White;
                    }
                }
            }

            
        }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
    }
}

