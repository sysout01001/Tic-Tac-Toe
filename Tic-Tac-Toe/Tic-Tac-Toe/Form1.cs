using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public string Current_Player = "X";
        public Form1()
        {
            InitializeComponent();
        }

        public string ReversesPlayer()
        {
            if(Current_Player == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
            return "X";
        }

        public void Reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            Current_Player = "X";
            label1.Text = "Current player: X";
        }
        public void Win()
        {
            MessageBox.Show("The player " + Current_Player + " won!");
            Reset();
        }

        public bool Verify(String actual_player)
        {
            if(button1.Text == actual_player && button4.Text == actual_player && button7.Text == actual_player)
            {
                Win();
                return true;
            }
            if (button2.Text == actual_player && button5.Text == actual_player && button8.Text == actual_player)
            {
                Win();
                return true;
            }
            if (button3.Text == actual_player && button6.Text == actual_player && button9.Text == actual_player)
            {
                Win();
                return true;
            }
            if (button1.Text == actual_player && button2.Text == actual_player && button3.Text == actual_player)
            {
                Win();
                return true;
            }
            if (button4.Text == actual_player && button5.Text == actual_player && button6.Text == actual_player)
            {
                Win();
                return true;
            }
            if (button7.Text == actual_player && button8.Text == actual_player && button9.Text == actual_player)
            {
                Win();
                return true;
            }
            if (button1.Text == actual_player && button5.Text == actual_player && button9.Text == actual_player)
            {
                Win();
                return true;
            }
            if (button3.Text == actual_player && button5.Text == actual_player && button7.Text == actual_player)
            {
                Win();
                return true;
            }
            if(button1.Text.Length != 0 && button2.Text.Length != 0 && button3.Text.Length != 0 && button4.Text.Length != 0 && button5.Text.Length != 0 && button6.Text.Length != 0 && button7.Text.Length != 0 && button8.Text.Length != 0 && button9.Text.Length != 0)
            {
                MessageBox.Show("Draw!");
                Reset();
                return true;
            }
            Current_Player = ReversesPlayer();
            label1.Text = "Current player: " + Current_Player;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "")
            {
                button1.Text = Current_Player;
                Verify(Current_Player);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = Current_Player;
                Verify(Current_Player);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = Current_Player;
                Verify(Current_Player);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = Current_Player;
                Verify(Current_Player);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = Current_Player;
                Verify(Current_Player);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = Current_Player;
                Verify(Current_Player);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = Current_Player;
                Verify(Current_Player);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = Current_Player;
                Verify(Current_Player);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = Current_Player;
                Verify(Current_Player);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
