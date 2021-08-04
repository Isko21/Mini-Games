using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BigBanTheory_Project2
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            loadProgBar.Value = 0;

        }

        private void loadProgBar_Click(object sender, EventArgs e)
        {

        }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            loadProgBar.Value += 1;
            loadProgBar.Text = loadProgBar.Value.ToString() + "%";

            if (loadProgBar.Value >= 100)
            {
                loadTimer.Enabled = false;
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }

        }
    }
}
