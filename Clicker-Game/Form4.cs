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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if(rateBar.Value != 0)
            {
                MessageBox.Show("Thank you for rating us!");
                this.Close();
            }
            if(rateBar.Value == 0)
            {
                MessageBox.Show("Rate PLEASE!");
            }
            else
            {
                this.Close();
            }
        }

        private void rateBar_onValueChanged(object sender, EventArgs e)
        {
            if(rateBar.Value == 0)
            {
                rateImg.Image = Properties.Resources.icons8_face_with_raised_eyebrow_100;
            }
            if (rateBar.Value == 1)
            {
                rateImg.Image = Properties.Resources.icons8_angry_face_100;
            }
            if (rateBar.Value == 2)
            {
                rateImg.Image = Properties.Resources.icons8_worried_face_100;
            }
            if (rateBar.Value == 3)
            {
                rateImg.Image = Properties.Resources.icons8_smiling_face_100;
            }
            if (rateBar.Value == 4)
            {
                rateImg.Image = Properties.Resources.icons8_winking_face_with_tongue_100;
            }
            if (rateBar.Value == 5)
            {
                rateImg.Image = Properties.Resources.icons8_star_struck_100;
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Width = 367;
            this.Height = 268;
        }
    }
}
