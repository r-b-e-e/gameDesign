using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;           
        int turn_count = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic-tac-toe is a paper-and-pencil game for two players, X and O, who take turns marking the spaces in a 3×3 grid. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row wins the game.", "About TicTacToe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            button.BackColor = Color.OrangeRed;
            turn = !turn;
            button.Enabled = false;
            turn_count = turn_count + 1;
            winnerCheck();
        }   

        private void winnerCheck()
        {
            bool win = false;
            if((R1C1.Text == R1C2.Text) && (R1C2.Text == R1C3.Text) && (!R1C1.Enabled))
            {
                win = true;
            }

            else if ((R2C1.Text == R2C2.Text) && (R2C2.Text == R2C3.Text) && (!R2C1.Enabled))
            {
                win = true;
            }

            else if ((R3C1.Text == R3C2.Text) && (R3C2.Text == R3C3.Text) && (!R3C1.Enabled))
            {
                win = true;
            }

            else if ((R1C1.Text == R2C1.Text) && (R2C1.Text == R3C1.Text) && (!R1C1.Enabled))
            {
                win = true;
            }

            else if ((R1C2.Text == R2C2.Text) && (R2C2.Text == R3C2.Text) && (!R1C2.Enabled))
            {
                win = true;
            }

            else if ((R1C3.Text == R2C3.Text) && (R2C3.Text == R3C3.Text) && (!R1C3.Enabled))
            {
                win = true;
            }

            else if ((R1C1.Text == R2C2.Text) && (R2C2.Text == R3C3.Text) && (!R2C2.Enabled))
            {
                win = true;
            }

            else if ((R1C3.Text == R2C2.Text) && (R2C2.Text == R3C1.Text) && (!R2C2.Enabled))
            {
                win = true;
            }

            if (win)
            {
                String gameWinner;
                disableRest();
                if (turn)
                {
                    gameWinner = "O";
                }
                else
                {
                    gameWinner = "X";
                }
                MessageBox.Show(gameWinner + " won", "Game Message");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Match Drawn", "Game Message");
                }
            }
        }

        private void disableRest()
        {
            try
            {
                foreach (Control control in Controls)
                {
                    Button button_disable = (Button)control;
                    button_disable.Enabled = false;
                }
            }
            catch
            {
                Exception exception1;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control control in Controls)
                {
                    Button button_enable = (Button)control;
                    button_enable.Enabled = true;
                    button_enable.Text = "";
                    button_enable.BackColor = Color.MistyRose;
                }
            }
            catch
            {
                Exception exception2;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
