﻿using System;
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
            MessageBox.Show("Welcome Players!\r\n\r\n Are you ready?!", "Tic Tac Toe", MessageBoxButtons.OK);
        
          }
        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (move == true)

                b.Text = "O";

            else
                b.Text = "X";

            move = !move;
            b.Enabled = false;
        }


        private void lblPlayer_Click(object sender, EventArgs e)
        {
          
        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }
    }
}
