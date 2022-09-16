using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLAN
{
    public partial class Game : Form
    {
        private char Player;
        private char Opponent;
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;
        public Game(bool isHost, string ip = null)
        {
            InitializeComponent();
            //MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;
        }


        private bool CheckState()
        {
            //Horizontals
            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {
                if (button1.Text[0] == Player)
                {
                    label1.Text = "You Won!";
                    MessageBox.Show("You Won!");
                }
                else
                {
                    label1.Text = "You Lost!";
                    MessageBox.Show("You Lost!");
                }
                return true;
            }

            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
            {
                if (button4.Text[0] == Player)
                {
                    label1.Text = "You Won!";
                    MessageBox.Show("You Won!");
                }
                else
                {
                    label1.Text = "You Lost!";
                    MessageBox.Show("You Lost!");
                }
                return true;
            }

            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
            {
                if (button7.Text[0] == Player)
                {
                    label1.Text = "You Won!";
                    MessageBox.Show("You Won!");
                }
                else
                {
                    label1.Text = "You Lost!";
                    MessageBox.Show("You Lost!");
                }
                return true;
            }

            //Verticals
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
            {
                if (button1.Text[0] == Player)
                {
                    label1.Text = "You Won!";
                    MessageBox.Show("You Won!");
                }
                else
                {
                    label1.Text = "You Lost!";
                    MessageBox.Show("You Lost!");
                }
                return true;
            }

            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
            {
                if (button2.Text[0] == Player)
                {
                    label1.Text = "You Won!";
                    MessageBox.Show("You Won!");
                }
                else
                {
                    label1.Text = "You Lost!";
                    MessageBox.Show("You Lost!");
                }
                return true;
            }

            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
            {
                if (button3.Text[0] == Player)
                {
                    label1.Text = "You Won!";
                    MessageBox.Show("You Won!");
                }
                else
                {
                    label1.Text = "You Lost!";
                    MessageBox.Show("You Lost!");
                }
                return true;
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
            {
                if (button1.Text[0] == Player)
                {
                    label1.Text = "You Won!";
                    MessageBox.Show("You Won!");
                }
                else
                {
                    label1.Text = "You Lost!";
                    MessageBox.Show("You Lost!");
                }
                return true;
            }

            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
            {
                if (button3.Text[0] == Player)
                {
                    label1.Text = "You Won!";
                    MessageBox.Show("You Won!");
                }
                else
                {
                    label1.Text = "You Lost!";
                    MessageBox.Show("You Lost!");
                }
                return true;
            }

            //Draw
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                label1.Text = "It's a draw!";
                MessageBox.Show("It's a draw!");
                return true;
            }
            return false;
        }
        private void FreezeBoard()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void UnfreezeBoard()
        {
            if (button1.Text == "")
                button1.Enabled = true;
            if (button2.Text == "")
                button2.Enabled = true;
            if (button3.Text == "")
                button3.Enabled = true;
            if (button4.Text == "")
                button4.Enabled = true;
            if (button5.Text == "")
                button5.Enabled = true;
            if (button6.Text == "")
                button6.Enabled = true;
            if (button7.Text == "")
                button7.Enabled = true;
            if (button8.Text == "")
                button8.Enabled = true;
            if (button9.Text == "")
                button9.Enabled = true;
        }
        private void ReceiveMove()
        {
            byte[] buffer = new byte[1];
            sock.Receive(buffer);
            if (buffer[0] == 1)
                button1.Text = Opponent.ToString();
            if (buffer[0] == 2)
                button2.Text = Opponent.ToString();
            if (buffer[0] == 3)
                button3.Text = Opponent.ToString();
            if (buffer[0] == 4)
                button4.Text = Opponent.ToString();
            if (buffer[0] == 5)
                button5.Text = Opponent.ToString();
            if (buffer[0] == 6)
                button6.Text = Opponent.ToString();
            if (buffer[0] == 7)
                button7.Text = Opponent.ToString();
            if (buffer[0] == 8)
                button8.Text = Opponent.ToString();
            if (buffer[0] == 9)
                button9.Text = Opponent.ToString();

        }

    }
}
