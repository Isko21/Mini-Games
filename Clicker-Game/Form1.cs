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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string name = "";
        private void playBtn_Click(object sender, EventArgs e)
        {
            if(nameBox.Text.Length == 0)
            {
                MessageBox.Show("Write your name please!");
            }
            else
            {
                name = Convert.ToString(nameBox.Text);
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
