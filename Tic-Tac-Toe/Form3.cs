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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int player;
        private void Form3_Load(object sender, EventArgs e)
        {
            player = 1;
        }

        private void moves(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "✖");
                    player = 2;
                    turn.Text = "Now ⚪'s turn!";
                    break;
                case 2:
                    sender.GetType().GetProperty("Text").SetValue(sender, "⚪");
                    player = 1;
                    turn.Text = "Now ✖'s turn!";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            WhoWins();
        }
        int player1 = 0;
        int player2 = 0;
        public void WhoWins()
        {
            if (btn1.Text == "⚪" && btn2.Text == "⚪" && btn3.Text == "⚪" ||
                btn4.Text == "⚪" && btn5.Text == "⚪" && btn6.Text == "⚪" ||
                btn7.Text == "⚪" && btn8.Text == "⚪" && btn9.Text == "⚪" ||
                btn2.Text == "⚪" && btn5.Text == "⚪" && btn8.Text == "⚪" ||
                btn1.Text == "⚪" && btn4.Text == "⚪" && btn7.Text == "⚪" ||
                btn3.Text == "⚪" && btn6.Text == "⚪" && btn9.Text == "⚪" ||
                btn1.Text == "⚪" && btn5.Text == "⚪" && btn9.Text == "⚪" ||
                btn3.Text == "⚪" && btn5.Text == "⚪" && btn7.Text == "⚪")
            {
                MessageBox.Show("Player2 wins!", "Game Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                player2 += 1;
                player2Score.Text = player2.ToString();
                ClearAllData();
            }
            if (btn1.Text == "✖" && btn2.Text == "✖" && btn3.Text == "✖" ||
                btn4.Text == "✖" && btn5.Text == "✖" && btn6.Text == "✖" ||
                btn7.Text == "✖" && btn8.Text == "✖" && btn9.Text == "✖" ||
                btn2.Text == "✖" && btn5.Text == "✖" && btn8.Text == "✖" ||
                btn1.Text == "✖" && btn4.Text == "✖" && btn7.Text == "✖" ||
                btn3.Text == "✖" && btn6.Text == "✖" && btn9.Text == "✖" ||
                btn1.Text == "✖" && btn5.Text == "✖" && btn9.Text == "✖" ||
                btn3.Text == "✖" && btn5.Text == "✖" && btn7.Text == "✖")
            {
                MessageBox.Show("Player1 wins!", "Game Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                player1 += 1;
                player1Score.Text = player1.ToString();
                ClearAllData();
            }
            if (btn1.Text.Length != 0 && btn2.Text.Length != 0 && btn3.Text.Length != 0 &&
                btn4.Text.Length != 0 && btn5.Text.Length != 0 && btn6.Text.Length != 0 &&
                btn7.Text.Length != 0 && btn8.Text.Length != 0 && btn9.Text.Length != 0)
            {
                MessageBox.Show("Draw!", "Game Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllData();
            }
        }
        private void ClearAllData()
        {
            List<Button> button = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for (int i = 0; i < 9; i++)
            {
                button[i].Text = "";
                button[i].Enabled = true;
            }
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            List<Button> button = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for (int i = 0; i < 9; i++)
            {
                button[i].Text = "";
                button[i].Enabled = true;
            }
            player1Score.Text = "0";
            player2Score.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
