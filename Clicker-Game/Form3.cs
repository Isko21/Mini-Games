using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBanTheory_Project2
{
    public partial class Form3 : Form
    {
        int score = 0;
        double time = 10;
        private int x_max;
        private int y_max;
        Random random = new Random();

        public Form3()
        {
            InitializeComponent();
            x_max = this.Width;
            y_max = this.Height;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            nameTxt.Text = Form1.name;
            image.Visible = false;
        }
        public int buttonX()
        {
            int rdmx = random.Next(161, this.Width - 150);
            return rdmx;
        }
        public int buttonY()
        {
            int rdmx = random.Next(66, this.Height - 150);
            return rdmx;
        }
        public void EasyLevel()
        {
            if (easyBtn.Checked)
            {
                SystemSettings();
            }
        }
        public void EasyRun()
        {
            score = score + 1;
            scoreInt.Text = "" + score;
            image.Location = new Point(buttonX(), buttonY());
            StartPosition = FormStartPosition.CenterScreen;
            if (score % 10 == 0)
            {
                PictureChange();
                double time1 = Convert.ToDouble(timeInt.Text);
                timeInt.Text = (time + time1).ToString();
                image.Width = image.Size.Width - 10;
                image.Height = image.Size.Height - 10;
                gameTime.Interval = gameTime.Interval - 100;
                this.Width += 10;
                this.Height += 10;
            }
        }
        public void MediumLevel()
        {
            if (mediumBtn.Checked)
            {
                SystemSettings();
            }
        }
        public void MediumRun()
        {
            score = score + 1;
            scoreInt.Text = "" + score;
            image.Location = new Point(buttonX(), buttonY());
            StartPosition = FormStartPosition.CenterScreen;
            if (score % 10 == 0)
            {
                PictureChange();
                double time1 = Convert.ToDouble(timeInt.Text);
                timeInt.Text = (time + time1).ToString();
                image.Width = image.Size.Width - 15;
                image.Height = image.Size.Height - 15;
                gameTime.Interval = gameTime.Interval - 200;
                this.Width += 20;
                this.Height += 20;
            }
        }
        public void HardLevel()
        {
            if (hardBtn.Checked)
            {
                SystemSettings();
            }
        }
        public void HardRun()
        {
            score = score + 1;
            scoreInt.Text = "" + score;
            image.Location = new Point(buttonX(), buttonY());
            StartPosition = FormStartPosition.CenterScreen;
            if (score % 10 == 0)
            {
                PictureChange();
                double time1 = Convert.ToDouble(timeInt.Text);
                timeInt.Text = (time + time1).ToString();
                image.Width = image.Size.Width - 20;
                image.Height = image.Size.Height - 20;
                gameTime.Interval =gameTime.Interval - 300;
                this.Width += 30;
                this.Height += 30;
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            scoreInt.Text = 0.ToString();
            this.Width = x_max;
            this.Height = y_max;
            if(easyBtn.Checked)
            {
                EasyLevel();
            }
            if (mediumBtn.Checked)
            {
                MediumLevel();
            }
            if(hardBtn.Checked)
            {
                HardLevel();
            }
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            double time = Convert.ToDouble(timeInt.Text);
            if (time == 0)
            {
                gameTime.Stop();
                image.Visible = false;
                gameOverTxt.Visible = true;
                gameOverTxt.Text = "Game over! Your score is: " + score;
                playBtn.Enabled = true;
                score = 0;
                foreach (RadioButton rButton in groupBox.Controls)
                {
                    rButton.Enabled = this.Enabled;
                }
                groupBox.Enabled = true;
            }
            else
            {
                time -= 1;
            }
            timeInt.Text = time.ToString();

        }
        public void SystemSettings()
        {
            this.Height = 500;
            this.Width = 700;
            gameTime.Start();
            image.Image = Properties.Resources.icons8_coronavirus_100;
            image.Width = 100;
            image.Height = 100;
            gameOverTxt.Text = "";
            gameOverTxt.Visible = false;
            image.Visible = true;
            playBtn.Enabled = false;
            gameTime.Interval = 1000;
            foreach (RadioButton rButton in groupBox.Controls)
            {
                rButton.Enabled = this.Enabled;
            }
            groupBox.Enabled = false;
            timeInt.Text = "10";
        }

        private void themeChanger_OnValueChange(object sender, EventArgs e)
        {
            if (themeChanger.Value == true)
            {
                panel1.BackColor = Color.FromArgb(128, 118, 117);
                panel2.BackColor = Color.FromArgb(128, 118, 117);
                this.BackColor = Color.FromArgb(235, 187, 115);
                welcomeTxt.ForeColor = Color.FromArgb(0, 0, 0);
                welcomeTxt.Font = new Font("Century Gothic", 16, FontStyle.Regular, GraphicsUnit.Point);
                welcomeTxt.TextAlign = ContentAlignment.MiddleCenter;
                label1.ForeColor = Color.FromArgb(0, 0, 0);
                label1.Font = new Font("Century Gothic", 20, FontStyle.Regular, GraphicsUnit.Point);
                label1.TextAlign = ContentAlignment.MiddleCenter;
                nameTxt.ForeColor = Color.FromArgb(0, 0, 0);
                nameTxt.Font = new Font("Century Gothic", 16, FontStyle.Bold, GraphicsUnit.Point);
                playBtn.Font = new Font("Century Gothic", 12, FontStyle.Regular, GraphicsUnit.Point);
                playBtn.IdleForecolor = Color.FromArgb(0, 0, 0);
                playBtn.IdleLineColor = Color.FromArgb(0, 0, 0);
                playBtn.IdleFillColor = Color.FromArgb(250, 250, 250);
                playBtn.ActiveFillColor = Color.FromArgb(0, 126, 249);
                playBtn.ActiveLineColor = Color.FromArgb(0, 0, 0);
                playBtn.ActiveForecolor = Color.FromArgb(250, 250, 250);
                timeLbl.Font = new Font("Century Gothic", 18, FontStyle.Regular, GraphicsUnit.Point);
                timeLbl.TextAlign = ContentAlignment.MiddleCenter;
                timeLbl.ForeColor = Color.FromArgb(0, 0, 0);
                timeInt.Font = new Font("Century Gothic", 18, FontStyle.Regular, GraphicsUnit.Point);
                timeInt.TextAlign = ContentAlignment.MiddleCenter;
                timeInt.ForeColor = Color.FromArgb(0, 0, 0);
                scoreLbl.Font = new Font("Century Gothic", 18, FontStyle.Regular, GraphicsUnit.Point);
                scoreLbl.TextAlign = ContentAlignment.MiddleCenter;
                scoreLbl.ForeColor = Color.FromArgb(0, 0, 0);
                scoreInt.Font = new Font("Century Gothic", 18, FontStyle.Regular, GraphicsUnit.Point);
                scoreInt.TextAlign = ContentAlignment.MiddleCenter;
                scoreInt.ForeColor = Color.FromArgb(0, 0, 0);
                themeLbl.Text = "Dark Mode";
                themeLbl.Font = new Font("Century Gothic", 14, FontStyle.Regular, GraphicsUnit.Point);
                themeLbl.TextAlign = ContentAlignment.MiddleCenter;
                themeLbl.ForeColor = Color.FromArgb(0, 0, 0);
                exitBtn.Font = new Font("Century Gothic", 12, FontStyle.Regular, GraphicsUnit.Point);
                exitBtn.IdleForecolor = Color.FromArgb(0, 0, 0);
                exitBtn.IdleLineColor = Color.FromArgb(0, 0, 0);
                exitBtn.IdleFillColor = Color.FromArgb(250, 250, 250);
                exitBtn.ActiveFillColor = Color.FromArgb(0, 126, 249);
                exitBtn.ActiveLineColor = Color.FromArgb(0, 0, 0);
                exitBtn.ActiveForecolor = Color.FromArgb(250, 250, 250);
                gameOverTxt.Font = new Font("Century Gothic", 24, FontStyle.Regular, GraphicsUnit.Point);
                gameOverTxt.TextAlign = ContentAlignment.MiddleCenter;
                gameOverTxt.ForeColor = Color.FromArgb(0, 0, 0);
                timePicture.Image = Properties.Resources.icons8_timer_100;
                scorePicture.Image = Properties.Resources.icons8_gold_medal_100;
                pictureBox1.Image = Properties.Resources.icons8_hunt_100;
                pictureBox2.Image = Properties.Resources.icons8_hunt_100;
                foreach (RadioButton rButton in groupBox.Controls)
                {
                    rButton.ForeColor = Color.FromArgb(0, 0, 0);
                }
                groupBox.ForeColor = Color.FromArgb(0, 0, 0);
                groupBox.Font = new Font("Century Gothic", 12, FontStyle.Regular, GraphicsUnit.Point);
            }
            if (themeChanger.Value == false)
            {
                panel2.BackColor = Color.FromArgb(24, 30, 54);
                panel1.BackColor = Color.FromArgb(24, 30, 54);
                this.BackColor = Color.FromArgb(46, 51, 73);
                foreach (RadioButton rButton in groupBox.Controls)
                {
                    rButton.ForeColor = Color.FromArgb(0, 126, 249);
                }
                groupBox.ForeColor = Color.FromArgb(0, 126, 249);
                groupBox.Font = new Font("Century Gothic", 12, FontStyle.Regular, GraphicsUnit.Point);
                welcomeTxt.ForeColor = Color.FromArgb(0, 126, 249);
                welcomeTxt.Font = new Font("Century Gothic", 16, FontStyle.Regular, GraphicsUnit.Point);
                welcomeTxt.TextAlign = ContentAlignment.MiddleCenter;
                label1.ForeColor = Color.FromArgb(0, 126, 249);
                label1.Font = new Font("Century Gothic", 20, FontStyle.Regular, GraphicsUnit.Point);
                label1.TextAlign = ContentAlignment.MiddleCenter;
                nameTxt.ForeColor = Color.FromArgb(0, 126, 249);
                nameTxt.Font = new Font("Century Gothic", 16, FontStyle.Bold, GraphicsUnit.Point);
                playBtn.Font = new Font("Century Gothic", 12, FontStyle.Regular, GraphicsUnit.Point);
                playBtn.IdleFillColor = Color.White;
                playBtn.IdleForecolor = Color.FromArgb(0, 126, 249);
                playBtn.IdleLineColor = Color.FromArgb(0, 126, 249);
                playBtn.ActiveFillColor = Color.FromArgb(192, 0, 192);
                playBtn.ActiveLineColor = Color.FromArgb(192, 0, 192);
                playBtn.ActiveForecolor = Color.White;
                timeLbl.Font = new Font("Century Gothic", 18, FontStyle.Regular, GraphicsUnit.Point);
                timeLbl.TextAlign = ContentAlignment.MiddleCenter;
                timeLbl.ForeColor = Color.FromArgb(0, 126, 249);
                timeInt.Font = new Font("Century Gothic", 18, FontStyle.Regular, GraphicsUnit.Point);
                timeInt.TextAlign = ContentAlignment.MiddleCenter;
                timeInt.ForeColor = Color.FromArgb(0, 126, 249);
                scoreLbl.Font = new Font("Century Gothic", 18, FontStyle.Regular, GraphicsUnit.Point);
                scoreLbl.TextAlign = ContentAlignment.MiddleCenter;
                scoreLbl.ForeColor = Color.FromArgb(0, 126, 249);
                scoreInt.Font = new Font("Century Gothic", 18, FontStyle.Regular, GraphicsUnit.Point);
                scoreInt.TextAlign = ContentAlignment.MiddleCenter;
                scoreInt.ForeColor = Color.FromArgb(0, 126, 249);
                themeLbl.Text = "Light Mode";
                themeLbl.Font = new Font("Century Gothic", 14, FontStyle.Regular, GraphicsUnit.Point);
                themeLbl.TextAlign = ContentAlignment.MiddleCenter;
                themeLbl.ForeColor = Color.FromArgb(0, 126, 249);
                exitBtn.Font = new Font("Century Gothic", 12, FontStyle.Regular, GraphicsUnit.Point);
                exitBtn.IdleFillColor = Color.White;
                exitBtn.IdleForecolor = Color.FromArgb(0, 126, 249);
                exitBtn.IdleLineColor = Color.FromArgb(0, 126, 249);
                exitBtn.ActiveFillColor = Color.FromArgb(192, 0, 192);
                exitBtn.ActiveLineColor = Color.FromArgb(192, 0, 192);
                exitBtn.ActiveForecolor = Color.White;
                gameOverTxt.Font = new Font("Century Gothic", 24, FontStyle.Regular, GraphicsUnit.Point);
                gameOverTxt.TextAlign = ContentAlignment.MiddleCenter;
                gameOverTxt.ForeColor = Color.FromArgb(0, 126, 249);
                timePicture.Image = Properties.Resources.icons8_time_64;
                scorePicture.Image = Properties.Resources.icons8_medal_64;
                pictureBox1.Image = Properties.Resources.icons8_hunt_96;
                pictureBox2.Image = Properties.Resources.icons8_hunt_96;
            }
        }
        public void PictureChange()
        {
            if(score == 10 || score == 40)
            {
                image.Image = Properties.Resources.covid19_icon_002;
            }
            if(score == 20 || score == 50)
            {
                image.Image = Properties.Resources.icons8_coronavirus_100__1_;
            }
            if(score == 30 || score == 60)
            {
                image.Image = Properties.Resources.icons8_coronavirus_100;
            }
            
        }
        private void image_Click(object sender, EventArgs e)
        {
            if (easyBtn.Checked)
            {
                EasyRun();
            }
            if (mediumBtn.Checked)
            {
                MediumRun();
            }
            if (hardBtn.Checked)
            {
                HardRun();
            }
        }
    }
}