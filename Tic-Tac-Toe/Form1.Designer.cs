
namespace Tic_Tac_Toe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gameWithFriend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gameWithAI = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // exit
            // 
            this.exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.BorderRadius = 7;
            this.exit.ButtonText = "Exit";
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.DisabledColor = System.Drawing.Color.Gray;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Iconcolor = System.Drawing.Color.Transparent;
            this.exit.Iconimage = null;
            this.exit.Iconimage_right = null;
            this.exit.Iconimage_right_Selected = null;
            this.exit.Iconimage_Selected = null;
            this.exit.IconMarginLeft = 0;
            this.exit.IconMarginRight = 0;
            this.exit.IconRightVisible = false;
            this.exit.IconRightZoom = 0D;
            this.exit.IconVisible = false;
            this.exit.IconZoom = 90D;
            this.exit.IsTab = false;
            this.exit.Location = new System.Drawing.Point(93, 438);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit.Name = "exit";
            this.exit.Normalcolor = System.Drawing.Color.Red;
            this.exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.exit.OnHoverTextColor = System.Drawing.Color.White;
            this.exit.selected = false;
            this.exit.Size = new System.Drawing.Size(157, 48);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Textcolor = System.Drawing.Color.White;
            this.exit.TextFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tic Tac Toe";
            // 
            // gameWithFriend
            // 
            this.gameWithFriend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.gameWithFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.gameWithFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameWithFriend.BorderRadius = 7;
            this.gameWithFriend.ButtonText = "VS";
            this.gameWithFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameWithFriend.DisabledColor = System.Drawing.Color.Gray;
            this.gameWithFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameWithFriend.Iconcolor = System.Drawing.Color.Transparent;
            this.gameWithFriend.Iconimage = global::Tic_Tac_Toe.Properties.Resources.icons8_user_100;
            this.gameWithFriend.Iconimage_right = global::Tic_Tac_Toe.Properties.Resources.icons8_user_100;
            this.gameWithFriend.Iconimage_right_Selected = null;
            this.gameWithFriend.Iconimage_Selected = null;
            this.gameWithFriend.IconMarginLeft = 0;
            this.gameWithFriend.IconMarginRight = 0;
            this.gameWithFriend.IconRightVisible = true;
            this.gameWithFriend.IconRightZoom = 100D;
            this.gameWithFriend.IconVisible = true;
            this.gameWithFriend.IconZoom = 100D;
            this.gameWithFriend.IsTab = false;
            this.gameWithFriend.Location = new System.Drawing.Point(93, 352);
            this.gameWithFriend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gameWithFriend.Name = "gameWithFriend";
            this.gameWithFriend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.gameWithFriend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.gameWithFriend.OnHoverTextColor = System.Drawing.Color.White;
            this.gameWithFriend.selected = false;
            this.gameWithFriend.Size = new System.Drawing.Size(157, 48);
            this.gameWithFriend.TabIndex = 2;
            this.gameWithFriend.Text = "VS";
            this.gameWithFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameWithFriend.Textcolor = System.Drawing.Color.White;
            this.gameWithFriend.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameWithFriend.Click += new System.EventHandler(this.gameWithFriend_Click);
            // 
            // gameWithAI
            // 
            this.gameWithAI.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.gameWithAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.gameWithAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameWithAI.BorderRadius = 7;
            this.gameWithAI.ButtonText = "VS";
            this.gameWithAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameWithAI.DisabledColor = System.Drawing.Color.Gray;
            this.gameWithAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameWithAI.Iconcolor = System.Drawing.Color.Transparent;
            this.gameWithAI.Iconimage = global::Tic_Tac_Toe.Properties.Resources.icons8_user_100;
            this.gameWithAI.Iconimage_right = global::Tic_Tac_Toe.Properties.Resources.icons8_broken_robot_100;
            this.gameWithAI.Iconimage_right_Selected = null;
            this.gameWithAI.Iconimage_Selected = null;
            this.gameWithAI.IconMarginLeft = 0;
            this.gameWithAI.IconMarginRight = 0;
            this.gameWithAI.IconRightVisible = true;
            this.gameWithAI.IconRightZoom = 100D;
            this.gameWithAI.IconVisible = true;
            this.gameWithAI.IconZoom = 100D;
            this.gameWithAI.IsTab = false;
            this.gameWithAI.Location = new System.Drawing.Point(93, 295);
            this.gameWithAI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gameWithAI.Name = "gameWithAI";
            this.gameWithAI.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.gameWithAI.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.gameWithAI.OnHoverTextColor = System.Drawing.Color.White;
            this.gameWithAI.selected = false;
            this.gameWithAI.Size = new System.Drawing.Size(157, 48);
            this.gameWithAI.TabIndex = 1;
            this.gameWithAI.Text = "VS";
            this.gameWithAI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameWithAI.Textcolor = System.Drawing.Color.White;
            this.gameWithAI.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameWithAI.Click += new System.EventHandler(this.gameWithAI_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe.Properties.Resources.tictactoe;
            this.pictureBox1.Location = new System.Drawing.Point(71, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(342, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.gameWithFriend);
            this.Controls.Add(this.gameWithAI);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton exit;
        private Bunifu.Framework.UI.BunifuFlatButton gameWithFriend;
        private Bunifu.Framework.UI.BunifuFlatButton gameWithAI;
    }
}

