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
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
        }


        SoundPlayer waitSound = new SoundPlayer();
        SoundPlayer clickSound = new SoundPlayer();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            waitSound.Stop();
            timer1.Start();
            clickSound.Play();
        }

        private void play_Load(object sender, EventArgs e)
        {
            waitSound.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\music\\chienthang.wav";
            clickSound.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\music\\click.wav";
            waitSound.PlayLooping();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            timer1.Stop();
        }

        private void play_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            waitSound.Stop();
        }
    }
}
