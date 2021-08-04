using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBanTheory_Project3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent(); 
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            player_Name1.Text = Players.Name1;
            player_Name2.Text = Players.Name2;
            player_Name3.Text = Players.Name3;
            player_Name4.Text = Players.Name4;
            player_Back1.BackColor = Players.Color1;
            player_Back2.BackColor = Players.Color2;
            player_Back3.BackColor = Players.Color3;
            player_Back4.BackColor = Players.Color4;
            rollBtn.Normalcolor = Players.Color1;
            saveBtn.Normalcolor = Players.Color1;
            rollBtn.OnHovercolor = Players.Color1;
            saveBtn.OnHovercolor = Players.Color1;
            turn.Text = "Now " + Players.Name1 + "'s turn!";
            turn.ForeColor = Players.Color1;
            goal = Players.goal;
            goallbl.Text = Players.goal.ToString();
            int number_of_players = Form2.num_players;
            if (number_of_players == 3)
            {
                player4_Bank.Visible = false;
                player4_Score.Visible = false;
                player_Back4.Visible = false;
                player_Name4.Visible = false;
            }
            if (number_of_players == 2)
            {
                player4_Bank.Visible = false;
                player4_Score.Visible = false;
                player_Back4.Visible = false;
                player_Name4.Visible = false;
                player_Name3.Visible = false;
                player_Back3.Visible = false;
                player3_Score.Visible = false;
                player3_Bank.Visible = false;
            }
            if (number_of_players == 1)
            {
                player4_Bank.Visible = false;
                player4_Score.Visible = false;
                player_Back4.Visible = false;
                player_Name4.Visible = false;
                player_Name3.Visible = false;
                player_Back3.Visible = false;
                player3_Score.Visible = false;
                player3_Bank.Visible = false;
                player2_Bank.Visible = false;
                player2_Score.Visible = false;
                player_Back2.Visible = false;
                player_Name2.Visible = false;
            }
        }
        private void close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void player_Back4_Paint(object sender, PaintEventArgs e)
        {
        }
        int dice, goal, score1 = 0, bank1= 0, bank2= 0, score2 = 0, bank3 = 0, score3 = 0, score4 = 0, bank4 = 0;
        int player = 1;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (Players.number_of_players == 4)
            {
                if (player == 1)
                {
                    bank1 = Convert.ToInt32(player1_Bank.Text);
                    player1_Bank.Text = (score1 + bank1).ToString();
                    player1_Score.Text = "0";
                    score1 = 0;
                    if (Convert.ToInt32(player1_Bank.Text) >= goal)
                    {
                        DialogResult dialogResult = MessageBox.Show(Players.Name1 + " win game! Do you want to restart the game?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                    }
                    if (player == 1)
                    {
                        player += 1;
                        rollBtn.Normalcolor = Players.Color2;
                        saveBtn.Normalcolor = Players.Color2;
                        turn.Text = "Now " + Players.Name2 + "'s turn!";
                        turn.ForeColor = Players.Color2;
                        rollBtn.OnHovercolor = Players.Color2;
                        saveBtn.OnHovercolor = Players.Color2;
                    }
                }
                else if (player == 2)
                {   
                    bank2 = Convert.ToInt32(player2_Bank.Text);
                    player2_Bank.Text = (score2 + bank2).ToString();
                    player2_Score.Text = "0";
                    score2 = 0;
                    if (Convert.ToInt32(player2_Bank.Text) >= goal)
                    {
                        DialogResult dialogResult = MessageBox.Show(Players.Name2 + " win game! Do you want to restart the game?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                    }
                    if (player == 2)
                    {
                        player += 1;
                        rollBtn.Normalcolor = Players.Color3;
                        saveBtn.Normalcolor = Players.Color3;
                        turn.Text = "Now " + Players.Name3 + "'s turn!";
                        turn.ForeColor = Players.Color3;
                        rollBtn.OnHovercolor = Players.Color3;
                        saveBtn.OnHovercolor = Players.Color3;
                    }
                }
                else if (player == 3)
                {
                    bank3 = Convert.ToInt32(player3_Bank.Text);
                    player3_Bank.Text = (score3 + bank3).ToString();
                    player3_Score.Text = "0";
                    score3 = 0;
                    if (Convert.ToInt32(player3_Bank.Text) > goal)
                    {
                        DialogResult dialogResult = MessageBox.Show(Players.Name3 + " win game! Do you want to restart the game?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                    }
                    if (player == 3)
                    {
                        player += 1;
                        rollBtn.Normalcolor = Players.Color4;
                        saveBtn.Normalcolor = Players.Color4;
                        turn.Text = "Now " + Players.Name4 + "'s turn!";
                        turn.ForeColor = Players.Color4;
                        rollBtn.OnHovercolor = Players.Color4;
                        saveBtn.OnHovercolor = Players.Color4;
                    }
                }
                else if (player == 4)
                {   
                    bank4 = Convert.ToInt32(player4_Bank.Text);
                    player4_Bank.Text = (score4 + bank4).ToString();
                    player4_Score.Text = "0";
                    score4 = 0;
                    if (Convert.ToInt32(player4_Bank.Text) >= goal)
                    {
                        DialogResult dialogResult = MessageBox.Show(Players.Name4 + " win game! Do you want to restart the game?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                    }
                    if (player == 4)
                    {
                        player = player - 3;
                        rollBtn.Normalcolor = Players.Color1;
                        saveBtn.Normalcolor = Players.Color1;
                        turn.Text = "Now " + Players.Name1 + "'s turn!";
                        turn.ForeColor = Players.Color1;
                        rollBtn.OnHovercolor = Players.Color1;
                        saveBtn.OnHovercolor = Players.Color1;
                    }
                }
            }
            if (Players.number_of_players == 3)
            {
                if (player == 1)
                {   
                    bank1 = Convert.ToInt32(player1_Bank.Text);
                    player1_Bank.Text = (score1 + bank1).ToString();
                    player1_Score.Text = "0";
                    score1 = 0;
                    if (Convert.ToInt32(player1_Bank.Text) >= goal)
                    {
                        DialogResult dialogResult = MessageBox.Show(Players.Name1 + " win game! Do you want to restart the game?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes) 
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                    }
                    if (player == 1)
                    {
                        player += 1;
                        rollBtn.Normalcolor = Players.Color2;
                        saveBtn.Normalcolor = Players.Color2;
                        turn.Text = "Now " + Players.Name2 + "'s turn!";
                        turn.ForeColor = Players.Color2;
                        rollBtn.OnHovercolor = Players.Color2;
                        saveBtn.OnHovercolor = Players.Color2;
                    }
                }
                else if (player == 2)
                {   
                    bank2 = Convert.ToInt32(player2_Bank.Text);
                    player2_Bank.Text = (score2 + bank2).ToString();
                    player2_Score.Text = "0";
                    score2 = 0;
                    if (Convert.ToInt32(player2_Bank.Text) >= goal)
                    {
                        DialogResult dialogResult = MessageBox.Show(Players.Name2 + " win game! Do you want to restart the game?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                    }
                    if (player == 2)
                    {
                        player += 1;
                        rollBtn.Normalcolor = Players.Color3;
                        saveBtn.Normalcolor = Players.Color3;
                        turn.Text = "Now " + Players.Name3 + "'s turn!";
                        turn.ForeColor = Players.Color3;
                        rollBtn.OnHovercolor = Players.Color3;
                        saveBtn.OnHovercolor = Players.Color3;
                    }
                }
                else if (player == 3)
                {
                    bank3 = Convert.ToInt32(player3_Bank.Text);
                    player3_Bank.Text = (score4 + bank4).ToString();
                    player3_Score.Text = "0";
                    score3 = 0;
                    if (Convert.ToInt32(player3_Bank.Text) >= goal)
                    {
                        DialogResult dialogResult = MessageBox.Show(Players.Name3 + " win game! Do you want to restart the game?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                    }
                    if (player == 3)
                    {
                        player = player - 2;
                        rollBtn.Normalcolor = Players.Color1;
                        saveBtn.Normalcolor = Players.Color1;
                        turn.Text = "Now " + Players.Name1 + "'s turn!";
                        turn.ForeColor = Players.Color1;
                        rollBtn.OnHovercolor = Players.Color1;
                        saveBtn.OnHovercolor = Players.Color1;
                    }
                }
            }
            if (Players.number_of_players == 2)
            {
                if (player == 1)
                { 
                    bank1 = Convert.ToInt32(player1_Bank.Text);
                    player1_Bank.Text = (score1 + bank1).ToString();
                    player1_Score.Text = "0";
                    score1 = 0;
                    if (Convert.ToInt32(player1_Bank.Text) >= goal)
                    {
                        DialogResult dialogResult = MessageBox.Show(Players.Name1 + " win game! Do you want to restart the game?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }

                    }
                    if (player == 1)
                    {
                        player += 1;
                        rollBtn.Normalcolor = Players.Color2;
                        saveBtn.Normalcolor = Players.Color2;
                        turn.Text = "Now " + Players.Name2 + "'s turn!";
                        turn.ForeColor = Players.Color2;
                        rollBtn.OnHovercolor = Players.Color2;
                        saveBtn.OnHovercolor = Players.Color2;
                    }
                }
                else if (player == 2)
                {
                    bank2 = Convert.ToInt32(player2_Bank.Text);
                    player2_Bank.Text = (score2 + bank2).ToString();
                    player2_Score.Text = "0";
                    score2 = 0;
                    if (Convert.ToInt32(player2_Bank.Text) >= goal)
                    {
                        DialogResult dialogResult = MessageBox.Show(Players.Name2 + " win game! Do you want to restart the game?", "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                    }
                    if (player == 2)
                    {
                        player = player - 1;
                        rollBtn.Normalcolor = Players.Color1;
                        saveBtn.Normalcolor = Players.Color1;
                        turn.Text = "Now " + Players.Name1 + "'s turn!";
                        turn.ForeColor = Players.Color1;
                        rollBtn.OnHovercolor = Players.Color1;
                        saveBtn.OnHovercolor = Players.Color1;
                    }
                }
            }
        }
        Random random = new Random();
        private void rollBtn_Click(object sender, EventArgs e)
        {
            if (Players.number_of_players == 4)
            {
                if (player == 1)
                {
                    dice = random.Next(1, 7);
                    switch (dice)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.icons8_dice_one_100;
                            score1 = score1 - score1;
                            player += 1;
                            rollBtn.Normalcolor = Players.Color2;
                            saveBtn.Normalcolor = Players.Color2;
                            turn.Text = "Now " + Players.Name2 + "'s turn!";
                            turn.ForeColor = Players.Color2;
                            rollBtn.OnHovercolor = Players.Color2;
                            saveBtn.OnHovercolor = Players.Color2;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.icons8_dice_two_100;
                            score1 += 2;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.icons8_dice_three_100;
                            score1 += 3;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.icons8_dice_four_100;
                            score1 += 4;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.icons8_dice_five_100;
                            score1 += 5;
                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.icons8_dice_six_100;
                            score1 += 6;
                            break;
                    }
                    player1_Score.Text = score1.ToString();
                }
                if (player == 2)
                {
                    dice = random.Next(1, 7);
                    switch (dice)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.icons8_dice_one_100;
                            score2 = score2 - score2;
                            player += 1;
                            rollBtn.Normalcolor = Players.Color3;
                            saveBtn.Normalcolor = Players.Color3;
                            turn.Text = "Now " + Players.Name3 + "'s turn!";
                            turn.ForeColor = Players.Color3;
                            rollBtn.OnHovercolor = Players.Color3;
                            saveBtn.OnHovercolor = Players.Color3;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.icons8_dice_two_100;
                            score2 += 2;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.icons8_dice_three_100;
                            score2 += 3;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.icons8_dice_four_100;
                            score2 += 4;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.icons8_dice_five_100;
                            score2 += 5;
                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.icons8_dice_six_100;
                            score2 += 6;
                            break;
                    }
                    player2_Score.Text = score2.ToString();
                }
                if (player == 4)
                {
                    dice = random.Next(1, 7);
                    switch (dice)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.icons8_dice_one_100;
                            score4 = score4 - score4;
                            player = player - 3;
                            rollBtn.Normalcolor = Players.Color1;
                            saveBtn.Normalcolor = Players.Color1;
                            rollBtn.OnHovercolor = Players.Color1;
                            saveBtn.OnHovercolor = Players.Color1;
                            turn.Text = "Now " + Players.Name1 + "'s turn!";
                            turn.ForeColor = Players.Color1;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.icons8_dice_two_100;
                            score4 += 2;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.icons8_dice_three_100;
                            score4 += 3;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.icons8_dice_four_100;
                            score4 += 4;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.icons8_dice_five_100;
                            score4 += 5;
                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.icons8_dice_six_100;
                            score4 += 6;
                            break;
                    }
                    player4_Score.Text = score4.ToString();
                }
                if (player == 3)
                {
                    dice = random.Next(1, 7);
                    switch (dice)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.icons8_dice_one_100;
                            score3 = score3 - score3;
                            player += 1;
                            rollBtn.Normalcolor = Players.Color4;
                            saveBtn.Normalcolor = Players.Color4;
                            rollBtn.OnHovercolor = Players.Color4;
                            saveBtn.OnHovercolor = Players.Color4;
                            turn.Text = "Now " + Players.Name4 + "'s turn!";
                            turn.ForeColor = Players.Color4;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.icons8_dice_two_100;
                            score3 += 2;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.icons8_dice_three_100;
                            score3 += 3;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.icons8_dice_four_100;
                            score3 += 4;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.icons8_dice_five_100;
                            score3 += 5;
                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.icons8_dice_six_100;
                            score3 += 6;
                            break;
                    }
                    player3_Score.Text = score3.ToString();
                }
            }
            if (Players.number_of_players == 3)
            {
                if (player == 1)
                {
                    dice = random.Next(1, 7);
                    switch (dice)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.icons8_dice_one_100;
                            score1 = score1 - score1;
                            player += 1;
                            rollBtn.Normalcolor = Players.Color2;
                            saveBtn.Normalcolor = Players.Color2;
                            turn.Text = "Now " + Players.Name2 + "'s turn!";
                            turn.ForeColor = Players.Color2;
                            rollBtn.OnHovercolor = Players.Color2;
                            saveBtn.OnHovercolor = Players.Color2;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.icons8_dice_two_100;
                            score1 += 2;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.icons8_dice_three_100;
                            score1 += 3;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.icons8_dice_four_100;
                            score1 += 4;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.icons8_dice_five_100;
                            score1 += 5;
                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.icons8_dice_six_100;
                            score1 += 6;
                            break;
                    }
                    player1_Score.Text = score1.ToString();
                }
                if (player == 2)
                {
                    dice = random.Next(1, 7);
                    switch (dice)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.icons8_dice_one_100;
                            score2 = score2 - score2;
                            player += 1;
                            rollBtn.Normalcolor = Players.Color3;
                            saveBtn.Normalcolor = Players.Color3;
                            turn.Text = "Now " + Players.Name3 + "'s turn!";
                            turn.ForeColor = Players.Color3;
                            rollBtn.OnHovercolor = Players.Color3;
                            saveBtn.OnHovercolor = Players.Color3;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.icons8_dice_two_100;
                            score2 += 2;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.icons8_dice_three_100;
                            score2 += 3;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.icons8_dice_four_100;
                            score2 += 4;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.icons8_dice_five_100;
                            score2 += 5;
                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.icons8_dice_six_100;
                            score2 += 6;
                            break;
                    }
                    player2_Score.Text = score2.ToString();
                }
                if (player == 3)
                {
                    dice = random.Next(1, 7);
                    switch (dice)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.icons8_dice_one_100;
                            score3 = score3 - score3;
                            player = player - 2;
                            rollBtn.Normalcolor = Players.Color1;
                            saveBtn.Normalcolor = Players.Color1;
                            rollBtn.OnHovercolor = Players.Color1;
                            saveBtn.OnHovercolor = Players.Color1;
                            turn.Text = "Now " + Players.Name1 + "'s turn!";
                            turn.ForeColor = Players.Color1;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.icons8_dice_two_100;
                            score3 += 2;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.icons8_dice_three_100;
                            score3 += 3;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.icons8_dice_four_100;
                            score3 += 4;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.icons8_dice_five_100;
                            score3 += 5;
                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.icons8_dice_six_100;
                            score3 += 6;
                            break;
                    }
                    player3_Score.Text = score3.ToString();
                }
            }
            if (Players.number_of_players == 2)
            {
                if (player == 1)
                {
                    dice = random.Next(1, 7);
                    switch (dice)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.icons8_dice_one_100;
                            score1 = score1 - score1;
                            player += 1;
                            rollBtn.Normalcolor = Players.Color2;
                            saveBtn.Normalcolor = Players.Color2;
                            turn.Text = "Now " + Players.Name2 + "'s turn!";
                            turn.ForeColor = Players.Color2;
                            rollBtn.OnHovercolor = Players.Color2;
                            saveBtn.OnHovercolor = Players.Color2;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.icons8_dice_two_100;
                            score1 += 2;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.icons8_dice_three_100;
                            score1 += 3;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.icons8_dice_four_100;
                            score1 += 4;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.icons8_dice_five_100;
                            score1 += 5;
                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.icons8_dice_six_100;
                            score1 += 6;
                            break;
                    }
                    player1_Score.Text = score1.ToString();
                }
                if (player == 2)
                {
                    dice = random.Next(1, 7);
                    switch (dice)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.icons8_dice_one_100;
                            score2 = score2 - score2;
                            player = player - 1;
                            rollBtn.Normalcolor = Players.Color1;
                            saveBtn.Normalcolor = Players.Color1;
                            rollBtn.OnHovercolor = Players.Color1;
                            saveBtn.OnHovercolor = Players.Color1;
                            turn.Text = "Now " + Players.Name1 + "'s turn!";
                            turn.ForeColor = Players.Color1;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.icons8_dice_two_100;
                            score2 += 2;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.icons8_dice_three_100;
                            score2 += 3;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.icons8_dice_four_100;
                            score2 += 4;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.icons8_dice_five_100;
                            score2 += 5;
                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.icons8_dice_six_100;
                            score2 += 6;
                            break;
                    }
                    player2_Score.Text = score2.ToString();
                }
            }
        }
    }
}