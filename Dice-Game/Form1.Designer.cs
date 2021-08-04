
namespace BigBanTheory_Project3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.ActiveBorderThickness = 1;
            this.playBtn.ActiveCornerRadius = 20;
            this.playBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.playBtn.ActiveForecolor = System.Drawing.Color.White;
            this.playBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.playBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.ButtonText = "Play";
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.playBtn.IdleBorderThickness = 1;
            this.playBtn.IdleCornerRadius = 20;
            this.playBtn.IdleFillColor = System.Drawing.Color.White;
            this.playBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.playBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.playBtn.Location = new System.Drawing.Point(132, 83);
            this.playBtn.Margin = new System.Windows.Forms.Padding(5);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(181, 49);
            this.playBtn.TabIndex = 0;
            this.playBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.ActiveBorderThickness = 1;
            this.exitBtn.ActiveCornerRadius = 20;
            this.exitBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.exitBtn.ActiveForecolor = System.Drawing.Color.White;
            this.exitBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.ButtonText = "Exit";
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.exitBtn.IdleBorderThickness = 1;
            this.exitBtn.IdleCornerRadius = 20;
            this.exitBtn.IdleFillColor = System.Drawing.Color.White;
            this.exitBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.exitBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.exitBtn.Location = new System.Drawing.Point(132, 142);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(181, 50);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 63);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(443, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Greedy Chicken";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "© 2021, BigBanTheory Inc.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::BigBanTheory_Project3.Properties.Resources.icons8_close_window_100;
            this.pictureBox2.Location = new System.Drawing.Point(398, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(443, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.playBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greedy Chicken";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 playBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

