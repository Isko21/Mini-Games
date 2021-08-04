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
    public partial class Form2 : Form
    {
        public static string player_Name1 = "";
        public static string player_Name2 = "";
        public static string player_Name3 = "";
        public static string player_Name4 = "";
        public static int goal_Play = 0;
        public static Color player_Color1;
        public static Color player_Color2;
        public static Color player_Color3;
        public static Color player_Color4;
        public static int num_players = 0;
        public Form2()
        {
            InitializeComponent();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void player1_Color(object sender, EventArgs e)
        {
            DialogResult result1 = colorDialog1.ShowDialog();
            if (result1 == DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
            }
        }

        private void player2_Color(object sender, EventArgs e)
        {
            DialogResult result2 = colorDialog1.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                panel4.BackColor = colorDialog1.Color;
            }
        }

        private void player3_Color(object sender, EventArgs e)
        {
            DialogResult result3 = colorDialog1.ShowDialog();
            if (result3 == DialogResult.OK)
            {
                panel3.BackColor = colorDialog1.Color;
            }
        }

        private void player4_Color(object sender, EventArgs e)
        {
            DialogResult result4 = colorDialog1.ShowDialog();
            if (result4 == DialogResult.OK)
            {
                panel5.BackColor = colorDialog1.Color;
            }
        }
        int goalPlay;
        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int numPlay = Convert.ToInt32(numOfPl.Text);
                goalPlay = Convert.ToInt32(goal.Text);
                if (numPlay == 0)
                {
                    MessageBox.Show("This value is not availble!", "Undefined value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Convert.ToInt32(goal.Text) > 1000 && Convert.ToInt32(goal.Text) < 10)
                {
                    MessageBox.Show("This value out of range!", "Undefined value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(numPlay <= 4 && goal.Text.Length > 0)
                {
                    
                    numOfPl.Enabled = false;
                    goal.Enabled = false;
                    if (numPlay == 4)
                    {
                        playBox.Enabled = true;
                        pla1.Enabled = true;
                        submitBtn.Enabled = false;
                        pla2.Enabled = true;
                        pla3.Enabled = true;
                        pla4.Enabled = true;
                        startBtn.Enabled = true;
                        num_players = numPlay;
                    }
                    if (numPlay == 3)
                    {
                        playBox.Enabled = true;
                        pla1.Enabled = true;
                        pla2.Enabled = true;
                        pla3.Enabled = true;
                        pla4.Enabled = false;
                        submitBtn.Enabled = false;
                        startBtn.Enabled = true;
                        num_players = numPlay;
                    }
                    if (numPlay == 2)
                    {
                        playBox.Enabled = true;
                        pla1.Enabled = true;
                        pla2.Enabled = true;
                        submitBtn.Enabled = false;
                        pla3.Enabled = false;
                        pla4.Enabled = false;
                        startBtn.Enabled = true;
                        num_players = numPlay;
                    }
                    if (numPlay == 1)
                    {
                        MessageBox.Show("You can't play yourself! " +
                            "At least 2 people are needed to continue the game.", "Unknown value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (numPlay > 4)
                {
                    MessageBox.Show("Maximum value of playes is 4!" + "Choose number in range 2 and including 4.", "Unknown value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Write only numbers!", "Unknown values", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            playBox.Enabled = false;
            startBtn.Enabled = false;
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (pla1.Text.Length == 0 && pla2.Text.Length == 0 && pla3.Text.Length == 0 && pla4.Text.Length == 0)
            {
                MessageBox.Show("Write name of players!", "Missing one of the elements",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Players.Name1 = pla1.Text;
                Players.Name2 = pla2.Text;
                Players.Name3 = pla3.Text;
                Players.Name4 = pla4.Text;
                Players.Color1 = panel2.BackColor;
                Players.Color2 = panel4.BackColor;
                Players.Color3 = panel3.BackColor;
                Players.Color4 = panel5.BackColor;
                Players.goal = goalPlay;
                Players.number_of_players = num_players;
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}