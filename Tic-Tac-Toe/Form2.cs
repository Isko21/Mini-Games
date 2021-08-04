using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        int yourScoreInt = 0;        //your score counter
        int computerScoreInt = 0;    //computers score counter
        List<Button> buttons;        //creating a list of buttons
        List<String> comments;       //creating a list of comments
        public Form2()
        {
            InitializeComponent();
        }
        //creating method which will appear your and computers comments then disappear after
        //a certain amount of time
        MethodTimer hideYour;
        MethodTimer showYour;
        MethodTimer hideComputers;
        MethodTimer showComputers;
        private void hideYou()   //creating method for make your comments unvisible
        {
            yourComment.Visible = false;
            yourSpeech.Visible = false;
        }
        private void hideNotYou()   //creating method for make computers comments unvisible
        {
            computersComment.Visible = false;
            computersSpeech.Visible = false;
        }
        private void showNotYou() //creating method to show computers comments
        {
            computersComment.Visible = true;
            computersSpeech.Visible = true;
        }
        private void showYou()   //creating method to show your comments
        {
            yourComment.Visible = true;
            yourSpeech.Visible = true;
        }

        private void t_Tick(object sender, EventArgs e)   //creating timing method
        {
            MethodTimer t = (MethodTimer)sender;
            t.Stop();
            t.Method.Invoke();
        }
        private void moves(object sender, EventArgs e)
        {
            var pressed = (Button)sender;   //pressed button
            pressed.Enabled = false;        //disable pressed button
            pressed.Text = "✖";            //put x in to pressed button
            if (pressed == btn5)            //comments for the right situation
            {
                yourComment.Text = comments[0].ToString();    //get comment from the list
                showYour.Start();           //show comment
                hideYour.Start();           //hide comment
            }

            //comments for the right situation
            if ( btn1.Text == "✖" && btn2.Text == "✖" && btn3.Text.Length == 0 ||
                btn4.Text == "✖" && btn5.Text == "✖" && btn6.Text.Length == 0 ||
                btn7.Text == "✖" && btn8.Text == "✖" && btn9.Text.Length == 0 ||

                btn1.Text.Length == 0 && btn2.Text == "✖" && btn3.Text == "✖" ||
                btn4.Text.Length == 0 && btn5.Text == "✖" && btn6.Text == "✖" ||
                btn7.Text.Length == 0 && btn8.Text == "✖" && btn9.Text == "✖" ||


                btn1.Text == "✖" && btn2.Text.Length == 0 && btn3.Text == "✖" ||
                btn4.Text == "✖" && btn5.Text.Length == 0 && btn6.Text == "✖" ||
                btn7.Text == "✖" && btn8.Text.Length == 0 && btn9.Text == "✖" ||

                btn1.Text == "✖" && btn5.Text.Length == 0 && btn9.Text == "✖" ||
                btn1.Text == "✖" && btn9.Text.Length == 0 && btn5.Text == "✖" ||
                btn5.Text == "✖" && btn1.Text.Length == 0 && btn9.Text == "✖" ||

                btn3.Text == "✖" && btn5.Text.Length == 0 && btn7.Text == "✖" ||
                btn3.Text == "✖" && btn7.Text.Length == 0 && btn5.Text == "✖" ||
                btn5.Text == "✖" && btn3.Text.Length == 0 && btn7.Text == "✖" ||

                btn2.Text.Length == 0 && btn5.Text == "✖" && btn8.Text == "✖" ||
                btn5.Text.Length == 0 && btn2.Text == "✖" && btn8.Text == "✖" ||
                btn8.Text.Length == 0 && btn5.Text == "✖" && btn2.Text == "✖" ||

                btn1.Text.Length == 0 && btn4.Text == "✖" && btn7.Text == "✖" ||
                btn4.Text.Length == 0 && btn1.Text == "✖" && btn7.Text == "✖" ||
                btn7.Text.Length == 0 && btn4.Text == "✖" && btn1.Text == "✖" ||

                btn3.Text.Length == 0 && btn6.Text == "✖" && btn9.Text == "✖" ||
                btn6.Text.Length == 0 && btn3.Text == "✖" && btn9.Text == "✖" ||
                btn9.Text.Length == 0 && btn6.Text == "✖" && btn3.Text == "✖")
            {
                yourComment.Text = comments[1].ToString();
                showYour.Start();
                hideYour.Start();
            }
            if( btn1.Text == "⚪" && btn2.Text == "⚪" && btn3.Text.Length == 0 ||
                btn4.Text == "⚪" && btn5.Text == "⚪" && btn6.Text.Length == 0 ||
                btn7.Text == "⚪" && btn8.Text == "⚪" && btn9.Text.Length == 0 ||

                btn1.Text.Length == 0 && btn2.Text == "⚪" && btn3.Text == "⚪" ||
                btn4.Text.Length == 0 && btn5.Text == "⚪" && btn6.Text == "⚪" ||
                btn7.Text.Length == 0 && btn8.Text == "⚪" && btn9.Text == "⚪" ||


                btn1.Text == "⚪" && btn2.Text.Length == 0 && btn3.Text == "⚪" ||
                btn4.Text == "⚪" && btn5.Text.Length == 0 && btn6.Text == "⚪" ||
                btn7.Text == "⚪" && btn8.Text.Length == 0 && btn9.Text == "⚪" ||

                btn1.Text == "⚪" && btn5.Text.Length == 0 && btn9.Text == "⚪" ||
                btn1.Text == "⚪" && btn9.Text.Length == 0 && btn5.Text == "⚪" ||
                btn5.Text == "⚪" && btn1.Text.Length == 0 && btn9.Text == "⚪" ||

                btn3.Text == "⚪" && btn5.Text.Length == 0 && btn7.Text == "⚪" ||
                btn3.Text == "⚪" && btn7.Text.Length == 0 && btn5.Text == "⚪" ||
                btn5.Text == "⚪" && btn3.Text.Length == 0 && btn7.Text == "⚪" ||

                btn2.Text.Length == 0 && btn5.Text == "⚪" && btn8.Text == "⚪" ||
                btn5.Text.Length == 0 && btn2.Text == "⚪" && btn8.Text == "⚪" ||
                btn8.Text.Length == 0 && btn5.Text == "⚪" && btn2.Text == "⚪" ||

                btn1.Text.Length == 0 && btn4.Text == "⚪" && btn7.Text == "⚪" ||
                btn4.Text.Length == 0 && btn1.Text == "⚪" && btn7.Text == "⚪" ||
                btn7.Text.Length == 0 && btn4.Text == "⚪" && btn1.Text == "⚪" ||

                btn3.Text.Length == 0 && btn6.Text == "⚪" && btn9.Text == "⚪" ||
                btn6.Text.Length == 0 && btn3.Text == "⚪" && btn9.Text == "⚪" ||
                btn9.Text.Length == 0 && btn6.Text == "⚪" && btn3.Text == "⚪")
            {
                yourComment.Text = comments[3].ToString();
                showYour.Start();
                hideYour.Start();
                
            }
            buttons.Remove(pressed);      //removing pressed button from the list
            WhoWins();                    //checkign if someone wins the game
            ComputerMove();               //calling method for computers move
        }
        private void ComputerMove()       //creating method for computers move
        {
            Random random = new Random();
            if (buttons.Count != 0)
            {
                int button = random.Next(buttons.Count);   //randomize a number from the buttons list
                buttons[button].Text = "⚪";               //set the value for the randomized button
                buttons[button].Enabled = false;            //make it disable
                if (buttons[button] == btn5)                //comments for the right situation
                {
                    computersComment.Text = comments[0].ToString();
                    showComputers.Start();
                    hideComputers.Start();
                }
                if (btn1.Text == "✖" && btn2.Text == "✖" && btn3.Text.Length == 0 ||
                    btn4.Text == "✖" && btn5.Text == "✖" && btn6.Text.Length == 0 ||
                    btn7.Text == "✖" && btn8.Text == "✖" && btn9.Text.Length == 0 ||

                    btn1.Text.Length == 0 && btn2.Text == "✖" && btn3.Text == "✖" ||
                    btn4.Text.Length == 0 && btn5.Text == "✖" && btn6.Text == "✖" ||
                    btn7.Text.Length == 0 && btn8.Text == "✖" && btn9.Text == "✖" ||


                    btn1.Text == "✖" && btn2.Text.Length == 0 && btn3.Text == "✖" ||
                    btn4.Text == "✖" && btn5.Text.Length == 0 && btn6.Text == "✖" ||
                    btn7.Text == "✖" && btn8.Text.Length == 0 && btn9.Text == "✖" ||

                    btn1.Text == "✖" && btn5.Text.Length == 0 && btn9.Text == "✖" ||
                    btn1.Text == "✖" && btn9.Text.Length == 0 && btn5.Text == "✖" ||
                    btn5.Text == "✖" && btn1.Text.Length == 0 && btn9.Text == "✖" ||

                    btn3.Text == "✖" && btn5.Text.Length == 0 && btn7.Text == "✖" ||
                    btn3.Text == "✖" && btn7.Text.Length == 0 && btn5.Text == "✖" ||
                    btn5.Text == "✖" && btn3.Text.Length == 0 && btn7.Text == "✖" ||

                    btn2.Text.Length == 0 && btn5.Text == "✖" && btn8.Text == "✖" ||
                    btn5.Text.Length == 0 && btn2.Text == "✖" && btn8.Text == "✖" ||
                    btn8.Text.Length == 0 && btn5.Text == "✖" && btn2.Text == "✖" ||

                    btn1.Text.Length == 0 && btn4.Text == "✖" && btn7.Text == "✖" ||
                    btn4.Text.Length == 0 && btn1.Text == "✖" && btn7.Text == "✖" ||
                    btn7.Text.Length == 0 && btn4.Text == "✖" && btn1.Text == "✖" ||

                    btn3.Text.Length == 0 && btn6.Text == "✖" && btn9.Text == "✖" ||
                    btn6.Text.Length == 0 && btn3.Text == "✖" && btn9.Text == "✖" ||
                    btn9.Text.Length == 0 && btn6.Text == "✖" && btn3.Text == "✖")
                {
                    computersComment.Text = comments[3].ToString();
                    showComputers.Start();
                    hideComputers.Start();
                }
                if (btn1.Text == "⚪" && btn2.Text == "⚪" && btn3.Text.Length == 0 ||
                    btn4.Text == "⚪" && btn5.Text == "⚪" && btn6.Text.Length == 0 ||
                    btn7.Text == "⚪" && btn8.Text == "⚪" && btn9.Text.Length == 0 ||

                    btn1.Text.Length == 0 && btn2.Text == "⚪" && btn3.Text == "⚪" ||
                    btn4.Text.Length == 0 && btn5.Text == "⚪" && btn6.Text == "⚪" ||
                    btn7.Text.Length == 0 && btn8.Text == "⚪" && btn9.Text == "⚪" ||


                    btn1.Text == "⚪" && btn2.Text.Length == 0 && btn3.Text == "⚪" ||
                    btn4.Text == "⚪" && btn5.Text.Length == 0 && btn6.Text == "⚪" ||
                    btn7.Text == "⚪" && btn8.Text.Length == 0 && btn9.Text == "⚪" ||

                    btn1.Text == "⚪" && btn5.Text.Length == 0 && btn9.Text == "⚪" ||
                    btn1.Text == "⚪" && btn9.Text.Length == 0 && btn5.Text == "⚪" ||
                    btn5.Text == "⚪" && btn1.Text.Length == 0 && btn9.Text == "⚪" ||

                    btn3.Text == "⚪" && btn5.Text.Length == 0 && btn7.Text == "⚪" ||
                    btn3.Text == "⚪" && btn7.Text.Length == 0 && btn5.Text == "⚪" ||
                    btn5.Text == "⚪" && btn3.Text.Length == 0 && btn7.Text == "⚪" ||

                    btn2.Text.Length == 0 && btn5.Text == "⚪" && btn8.Text == "⚪" ||
                    btn5.Text.Length == 0 && btn2.Text == "⚪" && btn8.Text == "⚪" ||
                    btn8.Text.Length == 0 && btn5.Text == "⚪" && btn2.Text == "⚪" ||

                    btn1.Text.Length == 0 && btn4.Text == "⚪" && btn7.Text == "⚪" ||
                    btn4.Text.Length == 0 && btn1.Text == "⚪" && btn7.Text == "⚪" ||
                    btn7.Text.Length == 0 && btn4.Text == "⚪" && btn1.Text == "⚪" ||

                    btn3.Text.Length == 0 && btn6.Text == "⚪" && btn9.Text == "⚪" ||
                    btn6.Text.Length == 0 && btn3.Text == "⚪" && btn9.Text == "⚪" ||
                    btn9.Text.Length == 0 && btn6.Text == "⚪" && btn3.Text == "⚪")
                {
                    computersComment.Text = comments[1].ToString();
                    showComputers.Start();
                    hideComputers.Start();

                }
                buttons.Remove(buttons[button]);      //removing randomized button from buttons list
            }
            WhoWins();                         //checking if someone wins the game
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };    //adding buttons to the list of buttons
            comments = new List<string> { "I got center!", "I win in the next move)", "Oh, no!", "You win in the next move!", "I think I lost this game(" };   //adding comments to the comment list
            hideComputers = new MethodTimer(hideNotYou);  //creating an object
            showComputers = new MethodTimer(showNotYou);  //creating an object
            hideYour = new MethodTimer(hideYou);          //creating an object
            showYour = new MethodTimer(showYou);          //creating an object
            hideComputers.Interval = 1500;                //setting the time
            showComputers.Interval = 1;                   //setting the time
            hideYour.Interval = 1500;                     //setting the time
            showYour.Interval = 1;                        //setting the time
            hideYour.Tick += new EventHandler(t_Tick);
            showYour.Tick += new EventHandler(t_Tick);
            hideComputers.Tick += new EventHandler(t_Tick);
            showComputers.Tick += new EventHandler(t_Tick);
            hideYou();                                    //hiding comments at the beginning
            hideNotYou();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllData();            //calling method clear
            buttons.Clear();           //clear all buttons which are not used in the previus game
            buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };   //adding all buttons for  the next game
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ClearAllData();          //clear all thing and make all of them as at the beginning of the game
            yourScore.Text = "0";
            computersScore.Text = "0";
        }
        public void ClearAllData()   //creating method which will clear all texts in the buttons and make them enable
        {
            List<Button> button = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for (int i = 0; i < 9; i++)
            {
                button[i].Text = "";    //clearing and enabling buttons
                button[i].Enabled = true;
            }
        }
        public void WhoWins()     //checks who wins
        {
            //this statement checks win computer the game
            if (btn1.Text == "⚪" && btn2.Text == "⚪" && btn3.Text == "⚪" ||
                btn4.Text == "⚪" && btn5.Text == "⚪" && btn6.Text == "⚪" ||
                btn7.Text == "⚪" && btn8.Text == "⚪" && btn9.Text == "⚪" ||
                btn2.Text == "⚪" && btn5.Text == "⚪" && btn8.Text == "⚪" ||
                btn1.Text == "⚪" && btn4.Text == "⚪" && btn7.Text == "⚪" ||
                btn3.Text == "⚪" && btn6.Text == "⚪" && btn9.Text == "⚪" ||
                btn1.Text == "⚪" && btn5.Text == "⚪" && btn9.Text == "⚪" ||
                btn3.Text == "⚪" && btn5.Text == "⚪" && btn7.Text == "⚪")
            {
                MessageBox.Show("Computer wins!", "Game Info", MessageBoxButtons.OK, MessageBoxIcon.Information);  //messagebox showing who wins
                computerScoreInt += 1;  //increasing computer's score
                computersScore.Text = computerScoreInt.ToString();
                ClearAllData();    //calling clear method
                buttons.Clear();    //clearing buttons from the list
                buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            }

            //this statement checks win you the game
            if (btn1.Text == "✖" && btn2.Text == "✖" && btn3.Text == "✖" ||
                btn4.Text == "✖" && btn5.Text == "✖" && btn6.Text == "✖" ||
                btn7.Text == "✖" && btn8.Text == "✖" && btn9.Text == "✖" ||
                btn2.Text == "✖" && btn5.Text == "✖" && btn8.Text == "✖" ||
                btn1.Text == "✖" && btn4.Text == "✖" && btn7.Text == "✖" ||
                btn3.Text == "✖" && btn6.Text == "✖" && btn9.Text == "✖" ||
                btn1.Text == "✖" && btn5.Text == "✖" && btn9.Text == "✖" ||
                btn3.Text == "✖" && btn5.Text == "✖" && btn7.Text == "✖")
            {
                MessageBox.Show("You win!", "Game Info", MessageBoxButtons.OK, MessageBoxIcon.Information);   //messagebox showing who wins
                yourScoreInt += 1;  //increasing your score
                yourScore.Text = yourScoreInt.ToString();
                ClearAllData();   //calling clear method
                buttons.Clear();
                buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            }

            //this statement check is there draw
            if (btn1.Text.Length != 0 && btn2.Text.Length != 0 && btn3.Text.Length != 0 &&
                btn4.Text.Length != 0 && btn5.Text.Length != 0 && btn6.Text.Length != 0 &&
                btn7.Text.Length != 0 && btn8.Text.Length != 0 && btn9.Text.Length != 0)
            {
                MessageBox.Show("Draw!", "Game Info", MessageBoxButtons.OK, MessageBoxIcon.Information);  //messagebox showing that nobody wins
                ClearAllData();   //calling clear methos
                buttons.Clear();
                buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            }
        }
        internal class MethodTimer : Timer   //creating class and inherit from timer class
        {
            public readonly MethodInvoker Method;
            public MethodTimer(MethodInvoker method)  //creating constructor and overload method
            {
                Method = method;
            }
        }

        private void btnBack_Click(object sender, EventArgs e) //switches to the main menu
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
