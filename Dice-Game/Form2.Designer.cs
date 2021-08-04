
namespace BigBanTheory_Project3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settingBox = new System.Windows.Forms.GroupBox();
            this.submitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.goal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.numOfPl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.playBox = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pla4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pla2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pla3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pla1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.startBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.settingBox.SuspendLayout();
            this.playBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 63);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::BigBanTheory_Project3.Properties.Resources.icons8_close_window_100;
            this.pictureBox2.Location = new System.Drawing.Point(637, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(682, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Greedy Chicken";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // settingBox
            // 
            this.settingBox.Controls.Add(this.submitBtn);
            this.settingBox.Controls.Add(this.goal);
            this.settingBox.Controls.Add(this.numOfPl);
            this.settingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingBox.Location = new System.Drawing.Point(54, 91);
            this.settingBox.Name = "settingBox";
            this.settingBox.Size = new System.Drawing.Size(575, 132);
            this.settingBox.TabIndex = 1;
            this.settingBox.TabStop = false;
            this.settingBox.Text = "Settings";
            // 
            // submitBtn
            // 
            this.submitBtn.ActiveBorderThickness = 1;
            this.submitBtn.ActiveCornerRadius = 20;
            this.submitBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.submitBtn.ActiveForecolor = System.Drawing.Color.White;
            this.submitBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.submitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitBtn.BackgroundImage")));
            this.submitBtn.ButtonText = "Submit";
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.submitBtn.IdleBorderThickness = 1;
            this.submitBtn.IdleCornerRadius = 20;
            this.submitBtn.IdleFillColor = System.Drawing.Color.White;
            this.submitBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.submitBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.submitBtn.Location = new System.Drawing.Point(417, 56);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(134, 41);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // goal
            // 
            this.goal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.goal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.goal.HintForeColor = System.Drawing.Color.Black;
            this.goal.HintText = "Goal";
            this.goal.isPassword = false;
            this.goal.LineFocusedColor = System.Drawing.Color.Blue;
            this.goal.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.goal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.goal.LineThickness = 4;
            this.goal.Location = new System.Drawing.Point(11, 72);
            this.goal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(340, 41);
            this.goal.TabIndex = 1;
            this.goal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numOfPl
            // 
            this.numOfPl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numOfPl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfPl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numOfPl.HintForeColor = System.Drawing.Color.Black;
            this.numOfPl.HintText = "Number of PLAYERS(max: 4)";
            this.numOfPl.isPassword = false;
            this.numOfPl.LineFocusedColor = System.Drawing.Color.Blue;
            this.numOfPl.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.numOfPl.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.numOfPl.LineThickness = 4;
            this.numOfPl.Location = new System.Drawing.Point(11, 21);
            this.numOfPl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numOfPl.Name = "numOfPl";
            this.numOfPl.Size = new System.Drawing.Size(340, 41);
            this.numOfPl.TabIndex = 1;
            this.numOfPl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // playBox
            // 
            this.playBox.Controls.Add(this.panel5);
            this.playBox.Controls.Add(this.panel4);
            this.playBox.Controls.Add(this.panel3);
            this.playBox.Controls.Add(this.panel2);
            this.playBox.Controls.Add(this.pla4);
            this.playBox.Controls.Add(this.pla2);
            this.playBox.Controls.Add(this.pla3);
            this.playBox.Controls.Add(this.pla1);
            this.playBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playBox.Location = new System.Drawing.Point(54, 229);
            this.playBox.Name = "playBox";
            this.playBox.Size = new System.Drawing.Size(575, 227);
            this.playBox.TabIndex = 2;
            this.playBox.TabStop = false;
            this.playBox.Text = "Players";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(527, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 40);
            this.panel5.TabIndex = 7;
            this.panel5.Click += new System.EventHandler(this.player4_Color);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lime;
            this.panel4.Location = new System.Drawing.Point(527, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 40);
            this.panel4.TabIndex = 7;
            this.panel4.Click += new System.EventHandler(this.player2_Color);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(238, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 40);
            this.panel3.TabIndex = 7;
            this.panel3.Click += new System.EventHandler(this.player3_Color);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(238, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 6;
            this.panel2.Click += new System.EventHandler(this.player1_Color);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pla4
            // 
            this.pla4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pla4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pla4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pla4.HintForeColor = System.Drawing.Color.Black;
            this.pla4.HintText = "Player 4:";
            this.pla4.isPassword = false;
            this.pla4.LineFocusedColor = System.Drawing.Color.Blue;
            this.pla4.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.pla4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pla4.LineThickness = 4;
            this.pla4.Location = new System.Drawing.Point(300, 137);
            this.pla4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pla4.Name = "pla4";
            this.pla4.Size = new System.Drawing.Size(219, 41);
            this.pla4.TabIndex = 5;
            this.pla4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pla2
            // 
            this.pla2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pla2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pla2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pla2.HintForeColor = System.Drawing.Color.Black;
            this.pla2.HintText = "Player 2:";
            this.pla2.isPassword = false;
            this.pla2.LineFocusedColor = System.Drawing.Color.Blue;
            this.pla2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.pla2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pla2.LineThickness = 4;
            this.pla2.Location = new System.Drawing.Point(300, 38);
            this.pla2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pla2.Name = "pla2";
            this.pla2.Size = new System.Drawing.Size(219, 41);
            this.pla2.TabIndex = 4;
            this.pla2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pla3
            // 
            this.pla3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pla3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pla3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pla3.HintForeColor = System.Drawing.Color.Black;
            this.pla3.HintText = "Player 3:";
            this.pla3.isPassword = false;
            this.pla3.LineFocusedColor = System.Drawing.Color.Blue;
            this.pla3.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.pla3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pla3.LineThickness = 4;
            this.pla3.Location = new System.Drawing.Point(11, 137);
            this.pla3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pla3.Name = "pla3";
            this.pla3.Size = new System.Drawing.Size(219, 41);
            this.pla3.TabIndex = 3;
            this.pla3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pla1
            // 
            this.pla1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pla1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pla1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pla1.HintForeColor = System.Drawing.Color.Black;
            this.pla1.HintText = "Player 1:";
            this.pla1.isPassword = false;
            this.pla1.LineFocusedColor = System.Drawing.Color.Blue;
            this.pla1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(186)))), ((int)(((byte)(26)))));
            this.pla1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pla1.LineThickness = 4;
            this.pla1.Location = new System.Drawing.Point(11, 38);
            this.pla1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pla1.Name = "pla1";
            this.pla1.Size = new System.Drawing.Size(219, 41);
            this.pla1.TabIndex = 2;
            this.pla1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.DimGray;
            // 
            // startBtn
            // 
            this.startBtn.ActiveBorderThickness = 1;
            this.startBtn.ActiveCornerRadius = 20;
            this.startBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.startBtn.ActiveForecolor = System.Drawing.Color.White;
            this.startBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.startBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startBtn.BackgroundImage")));
            this.startBtn.ButtonText = "Start";
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.startBtn.IdleBorderThickness = 1;
            this.startBtn.IdleCornerRadius = 20;
            this.startBtn.IdleFillColor = System.Drawing.Color.White;
            this.startBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.startBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.startBtn.Location = new System.Drawing.Point(246, 467);
            this.startBtn.Margin = new System.Windows.Forms.Padding(5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(190, 41);
            this.startBtn.TabIndex = 3;
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(682, 515);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.playBox);
            this.Controls.Add(this.settingBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.settingBox.ResumeLayout(false);
            this.playBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox settingBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox numOfPl;
        private System.Windows.Forms.GroupBox playBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox goal;
        private Bunifu.Framework.UI.BunifuThinButton2 submitBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pla1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pla4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pla2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pla3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 startBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}