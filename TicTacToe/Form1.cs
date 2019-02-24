using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool gameStarting;
        bool xTurn = true;
        int counter = 0;
        private void Button_Click(object sender, EventArgs e)
        {
            gameStarting = true;
            Button senderB = (Button)sender;
            if (senderB.Text == "")
            {
                if (xTurn)
                {
                    senderB.Text = "X";
                }
                else
                {
                    senderB.Text = "O";
                }
                counter++;
                xTurn = !xTurn;
            }
            CheckWin(senderB);
        }
        void CheckWin(Button pressedButton)
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                DialogResult result = MessageBox.Show("Player " + pressedButton.Text + " won!!!", "Congratulation", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                { Application.Exit(); }
                else { Application.Restart(); }
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                DialogResult result = MessageBox.Show("Player " + pressedButton.Text + " won!!!", "Congratulation", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                { Application.Exit(); }
                else { Application.Restart(); }
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                DialogResult result = MessageBox.Show("Player " + pressedButton.Text + " won!!!", "Congratulation", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                { Application.Exit(); }
                else { Application.Restart(); }
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                DialogResult result = MessageBox.Show("Player " + pressedButton.Text + " won!!!", "Congratulation", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                { Application.Exit(); }
                else { Application.Restart(); }
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                DialogResult result = MessageBox.Show("Player " + pressedButton.Text + " won!!!", "Congratulation", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                { Application.Exit(); }
                else { Application.Restart(); }
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                DialogResult result = MessageBox.Show("Player " + pressedButton.Text + " won!!!", "Congratulation", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                { Application.Exit(); }
                else { Application.Restart(); }
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                DialogResult result = MessageBox.Show("Player " + pressedButton.Text + " won!!!", "Congratulation", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                { Application.Exit(); }
                else { Application.Restart(); }
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                DialogResult result = MessageBox.Show("Player " + pressedButton.Text + " won!!!", "Congratulation", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                { Application.Exit(); }
                else { Application.Restart(); }
            }
            if(counter == 9)
            {
                DialogResult result = MessageBox.Show("Game draw!!!", "Warning!", MessageBoxButtons.RetryCancel, 
                    MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                { Application.Exit(); }
                else { Application.Restart(); }
            }
  
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameStarting)
            {
                xTurn = true;
            }
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameStarting)
            {
                xTurn = false;
            }
        }

        private void choosePlayedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
