using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {

        // Create an array of coins, list of coins. 5 coins total

        Coin[] coins = new Coin[5];

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            // initialized label1 text to be empty 
            label1.Text = "";

            for (int i = 0; i < coins.Length; i++)
            {
                label1.Text += coins[i].isHeads + ",";
                coins[i].flipCoin(r);
            }

            // Ternery operators. Faster, set images for the coins if heads or tails.
            pictureBox1.Image = coins[0].isHeads ? Properties.Resources.Coin_head : Properties.Resources.Coin_tail;
            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.Coin_head : Properties.Resources.Coin_tail;
            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.Coin_head : Properties.Resources.Coin_tail;
            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.Coin_head : Properties.Resources.Coin_tail;
            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.Coin_head : Properties.Resources.Coin_tail;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Coin(false);              
            }
        }

    }      
}
