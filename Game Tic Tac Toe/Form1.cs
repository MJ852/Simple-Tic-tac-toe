using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Tic_Tac_Toe
{


    public partial class Form1 : Form
    {

        bool move = true;
        int move_count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
          

            { 
            Button bText = (Button)sender;

                if (move)
                {
                    bText.Text = "O";

                }
                else
                {
                    bText.Text = "X";
   
                }
            

               move = !move;
               bText.Enabled = false;

                // Changing lblPlayer Text
                if (move == false)

                    lblPlayer.Text = "Next Move: Player X";

                else
                    lblPlayer.Text = "Next Move: Player O";

                // Changing lblPlayer color
                if (move == false)
                    lblPlayer.ForeColor = Color.DarkOrange;

                else
                    lblPlayer.ForeColor = Color.RoyalBlue;

                // Button Back color
                if (move == true)
                    bText.BackColor = Color.DarkSalmon;

                else
                    bText.BackColor = Color.PowderBlue;

                // Button Text Color
                if (move == true)
                    bText.ForeColor = Color.OldLace;

                else
                    bText.ForeColor = Color.AliceBlue;

                move_count++;
                CheckingofWinner("O");
                CheckingofWinner("X");
                
                

            }

         
            
        }


        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }

        private void CheckingofWinner(string symbol)
        {

            //horizontal
           
            if (btn1.Text == symbol && btn2.Text == symbol && btn3.Text == symbol)
            {
                MessageBox.Show("Player " + symbol + " Won the game!!", "Congratulations!");
                disableButtons();
            }
            else
                  if (btn4.Text == symbol && btn5.Text == symbol && btn6.Text == symbol)
                    {
                        MessageBox.Show("Player " + symbol + " Won the game!!", "Congratulations!");
                        disableButtons();
                    }
                    else if (btn7.Text == symbol && btn8.Text == symbol && btn9.Text == symbol)
                    {
                        MessageBox.Show("Player " + symbol + " Won the game!!", "Congratulations!");
                    disableButtons();
                    }

            // vertical
                    else if (btn1.Text == symbol && btn4.Text == symbol && btn7.Text == symbol)
                     {
                        MessageBox.Show("Player " + symbol + " Won the game!!", "Congratulations!");
                        disableButtons();

                        }
                    else if (btn2.Text == symbol && btn5.Text == symbol && btn8.Text == symbol)
                    {   
                        MessageBox.Show("Player " + symbol + " Won the game!!", "Congratulations!");
                        disableButtons();

                        }
                    else if (btn3.Text == symbol && btn6.Text == symbol && btn9.Text == symbol)
                    {
                         MessageBox.Show("Player " + symbol + " Won the game!!", "Congratulations!");
                        disableButtons();

                     }

            //diagonal

                    else if (btn1.Text == symbol && btn5.Text == symbol && btn9.Text == symbol)
                       {
                        MessageBox.Show("Player " + symbol + " Won the game!!", "Congratulations!");
                        disableButtons();

                        }
                    else if (btn3.Text == symbol && btn5.Text == symbol && btn7.Text == symbol)
                        {
                         MessageBox.Show("Player " + symbol + " Won the game!!", "Congratulations!");
                        disableButtons();

                         }
                    else if (move_count == 9)
                        {
                          MessageBox.Show("No winner! Please try again!", "Draw!");
                        disableButtons();
                        }


            




        }

        private void disableButtons()
        {

            try
            {
                foreach (Control c in Controls)
                {
                    Button bText = (Button)c;
                    bText.Enabled = false;
                    btn_Exit.Enabled = true;
                    btn_Reset.Enabled = true;   
                }
            }
            catch { }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        



    }



}
        

    

