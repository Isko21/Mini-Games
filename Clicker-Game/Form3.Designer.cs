
using System;

namespace BigBanTheory_Project2
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.themeChanger = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.themeLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.playBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.scorePicture = new System.Windows.Forms.PictureBox();
            this.timePicture = new System.Windows.Forms.PictureBox();
            this.scoreInt = new System.Windows.Forms.Label();
            this.timeInt = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.exitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.hardBtn = new System.Windows.Forms.RadioButton();
            this.mediumBtn = new System.Windows.Forms.RadioButton();
            this.easyBtn = new System.Windows.Forms.RadioButton();
            this.nameTxt = new System.Windows.Forms.Label();
            this.welcomeTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gameOverTxt = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePicture)).BeginInit();
            this.groupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.themeChanger);
            this.panel1.Controls.Add(this.themeLbl);
            this.panel1.Controls.Add(this.scoreLbl);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Controls.Add(this.scorePicture);
            this.panel1.Controls.Add(this.timePicture);
            this.panel1.Controls.Add(this.scoreInt);
            this.panel1.Controls.Add(this.timeInt);
            this.panel1.Controls.Add(this.timeLbl);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.groupBox);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.welcomeTxt);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 500);
            this.panel1.TabIndex = 0;
            // 
            // themeChanger
            // 
            this.themeChanger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.themeChanger.AutoSize = true;
            this.themeChanger.BackColor = System.Drawing.Color.Transparent;
            this.themeChanger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("themeChanger.BackgroundImage")));
            this.themeChanger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.themeChanger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themeChanger.Location = new System.Drawing.Point(113, 394);
            this.themeChanger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.themeChanger.Name = "themeChanger";
            this.themeChanger.OffColor = System.Drawing.Color.LimeGreen;
            this.themeChanger.OnColor = System.Drawing.Color.MediumBlue;
            this.themeChanger.Padding = new System.Windows.Forms.Padding(5);
            this.themeChanger.Size = new System.Drawing.Size(35, 20);
            this.themeChanger.TabIndex = 18;
            this.themeChanger.Value = false;
            this.themeChanger.OnValueChange += new System.EventHandler(this.themeChanger_OnValueChange);
            // 
            // themeLbl
            // 
            this.themeLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.themeLbl.AutoSize = true;
            this.themeLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themeLbl.ForeColor = System.Drawing.Color.White;
            this.themeLbl.Location = new System.Drawing.Point(3, 392);
            this.themeLbl.Name = "themeLbl";
            this.themeLbl.Size = new System.Drawing.Size(113, 22);
            this.themeLbl.TabIndex = 17;
            this.themeLbl.Text = "Light Mode";
            // 
            // scoreLbl
            // 
            this.scoreLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLbl.Location = new System.Drawing.Point(45, 305);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(80, 30);
            this.scoreLbl.TabIndex = 13;
            this.scoreLbl.Text = "Score";
            // 
            // playBtn
            // 
            this.playBtn.ActiveBorderThickness = 1;
            this.playBtn.ActiveCornerRadius = 20;
            this.playBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playBtn.ActiveForecolor = System.Drawing.Color.White;
            this.playBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.playBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.ButtonText = "Play";
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.playBtn.IdleBorderThickness = 1;
            this.playBtn.IdleCornerRadius = 20;
            this.playBtn.IdleFillColor = System.Drawing.Color.White;
            this.playBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.playBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.playBtn.Location = new System.Drawing.Point(36, 74);
            this.playBtn.Margin = new System.Windows.Forms.Padding(5);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(89, 45);
            this.playBtn.TabIndex = 9;
            this.playBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // scorePicture
            // 
            this.scorePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scorePicture.Image = global::BigBanTheory_Project2.Properties.Resources.icons8_medal_64;
            this.scorePicture.Location = new System.Drawing.Point(7, 303);
            this.scorePicture.Name = "scorePicture";
            this.scorePicture.Size = new System.Drawing.Size(40, 40);
            this.scorePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scorePicture.TabIndex = 16;
            this.scorePicture.TabStop = false;
            // 
            // timePicture
            // 
            this.timePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timePicture.Image = global::BigBanTheory_Project2.Properties.Resources.icons8_time_64;
            this.timePicture.Location = new System.Drawing.Point(7, 240);
            this.timePicture.Name = "timePicture";
            this.timePicture.Size = new System.Drawing.Size(40, 40);
            this.timePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.timePicture.TabIndex = 15;
            this.timePicture.TabStop = false;
            // 
            // scoreInt
            // 
            this.scoreInt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scoreInt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreInt.Location = new System.Drawing.Point(0, 334);
            this.scoreInt.Name = "scoreInt";
            this.scoreInt.Size = new System.Drawing.Size(160, 30);
            this.scoreInt.TabIndex = 14;
            this.scoreInt.Text = "0";
            this.scoreInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeInt
            // 
            this.timeInt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeInt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeInt.Location = new System.Drawing.Point(0, 273);
            this.timeInt.Name = "timeInt";
            this.timeInt.Size = new System.Drawing.Size(160, 30);
            this.timeInt.TabIndex = 12;
            this.timeInt.Text = "10";
            this.timeInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLbl.Location = new System.Drawing.Point(45, 243);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(70, 30);
            this.timeLbl.TabIndex = 11;
            this.timeLbl.Text = "Time";
            // 
            // exitBtn
            // 
            this.exitBtn.ActiveBorderThickness = 1;
            this.exitBtn.ActiveCornerRadius = 20;
            this.exitBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.exitBtn.ActiveForecolor = System.Drawing.Color.White;
            this.exitBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.ButtonText = "Exit";
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.exitBtn.IdleBorderThickness = 1;
            this.exitBtn.IdleCornerRadius = 20;
            this.exitBtn.IdleFillColor = System.Drawing.Color.White;
            this.exitBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.exitBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.exitBtn.Location = new System.Drawing.Point(36, 441);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(89, 45);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox.Controls.Add(this.hardBtn);
            this.groupBox.Controls.Add(this.mediumBtn);
            this.groupBox.Controls.Add(this.easyBtn);
            this.groupBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox.Location = new System.Drawing.Point(22, 129);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(117, 102);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Difficulty";
            // 
            // hardBtn
            // 
            this.hardBtn.AutoSize = true;
            this.hardBtn.Location = new System.Drawing.Point(15, 72);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(62, 24);
            this.hardBtn.TabIndex = 2;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            // 
            // mediumBtn
            // 
            this.mediumBtn.AutoSize = true;
            this.mediumBtn.Location = new System.Drawing.Point(15, 45);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(87, 24);
            this.mediumBtn.TabIndex = 1;
            this.mediumBtn.Text = "Medium";
            this.mediumBtn.UseVisualStyleBackColor = true;
            // 
            // easyBtn
            // 
            this.easyBtn.AutoSize = true;
            this.easyBtn.Location = new System.Drawing.Point(15, 17);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(59, 24);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTxt.Location = new System.Drawing.Point(0, 39);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(160, 42);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.Text = "Isko";
            this.nameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeTxt
            // 
            this.welcomeTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.welcomeTxt.AutoSize = true;
            this.welcomeTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeTxt.Location = new System.Drawing.Point(25, 17);
            this.welcomeTxt.Name = "welcomeTxt";
            this.welcomeTxt.Size = new System.Drawing.Size(111, 24);
            this.welcomeTxt.TabIndex = 0;
            this.welcomeTxt.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 66);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(129, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coronavirus Killer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BigBanTheory_Project2.Properties.Resources.icons8_hunt_96;
            this.pictureBox1.Location = new System.Drawing.Point(65, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::BigBanTheory_Project2.Properties.Resources.icons8_hunt_96;
            this.pictureBox2.Location = new System.Drawing.Point(366, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // gameOverTxt
            // 
            this.gameOverTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gameOverTxt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverTxt.Location = new System.Drawing.Point(160, 65);
            this.gameOverTxt.Name = "gameOverTxt";
            this.gameOverTxt.Size = new System.Drawing.Size(540, 435);
            this.gameOverTxt.TabIndex = 2;
            this.gameOverTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTime
            // 
            this.gameTime.Interval = 10;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // image
            // 
            this.image.Image = global::BigBanTheory_Project2.Properties.Resources.icons8_coronavirus_100;
            this.image.Location = new System.Drawing.Point(367, 190);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(100, 100);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 19;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.image);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameOverTxt);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePicture)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        private void virusBox_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label welcomeTxt;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton hardBtn;
        private System.Windows.Forms.RadioButton mediumBtn;
        private System.Windows.Forms.RadioButton easyBtn;
        private System.Windows.Forms.Label scoreInt;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label timeInt;
        private System.Windows.Forms.Label timeLbl;
        private Bunifu.Framework.UI.BunifuThinButton2 exitBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 playBtn;
        private System.Windows.Forms.Label gameOverTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 playButton;
        private Bunifu.Framework.UI.BunifuiOSSwitch themeChanger;
        private System.Windows.Forms.Label themeLbl;
        private System.Windows.Forms.PictureBox scorePicture;
        private System.Windows.Forms.PictureBox timePicture;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.PictureBox image;
    }
}