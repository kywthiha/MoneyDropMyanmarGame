using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ManyDrop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void openTime_Tick(object sender, EventArgs e)
        {
            openTime.Stop();
            play p = new play();
            this.Hide();
            p.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            openTime.Start();
            SoundPlayer homeSound = new SoundPlayer();
            homeSound.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\music\\moneydrophome.wav";
            homeSound.Play();

        }
    }
}
