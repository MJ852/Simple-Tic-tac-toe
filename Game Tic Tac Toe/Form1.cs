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
        string Player1 = "O";
        string Player2 = "X";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome Players!\r\n\r\n Are you ready?!", "Tic Tac Toe", MessageBoxButtons.OK);
        
          }
        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {
          
        }
    }
}
