using ManyDrop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyDrop
{
    public partial class GameWin : Form
    {
        public GameWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            play p = new play();
            p.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public GameWin(int money)
        {
            InitializeComponent();
            if (money < 10) {
                lbMoney.Text = money + " သိန်း";
            }
            if (money >= 10) {
               
                lbMoney.Text = "သိန်း " + money;
            }
           
        }
        private void GameWin_Load(object sender, EventArgs e)
        {

        }
    }
}
