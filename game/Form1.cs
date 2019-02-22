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
namespace game
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0;
        int z = 2, cunt = 0;

        GenreateFire obj = new GenreateFire();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\lakshay sharma\source\repos\game\game\picture\Gun_Cocking_Fast-Mike_Koenig-465593588.wav");
            splayer.Play();
            x = x + 1;
            if (x == 1)
            {

                pictureBox1.ImageLocation = @"C:\Users\lakshay sharma\source\repos\game\game\picture\gettyimages-BC0155-001-1024x1024.jpg";

            }
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\lakshay sharma\source\repos\game\game\picture\Chambering A Round-SoundBible.com-854171848 (1).wav");
                splayer.Play();
            }

            if (x > 0)
            {

                pictureBox2.ImageLocation = @"C:\Users\lakshay sharma\source\repos\game\game\picture\gettyimages-596279244-1024x1024.jpg";
            }
            else
            {
                MessageBox.Show("Please Click on Load Bullet First");
            }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            cunt = 0;
            btnFire.Enabled = true;
            pictureBox1.ImageLocation = @"C:\Users\lakshay sharma\source\repos\game\game\picture\using-right-handed-gun-left-hander-01.jpg";
            pictureBox2.ImageLocation = @"C:\Users\lakshay sharma\source\repos\game\game\picture\images.jpg";

        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                y++;
                pictureBox1.ImageLocation = @"C:\Users\lakshay sharma\source\repos\game\game\picture\tenor.gif";
                if (y == z && cunt < 2)
                {
                    cunt++;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\lakshay sharma\source\repos\game\game\picture\gun-gunshot-01.wav");
                    player.Play();
                    z = obj.fire();
                }
                if (cunt == 1)
                {
                    MessageBox.Show("Game Over Bullets Finished");
                    btnFire.Enabled = false;
                }
            }
        }
    }
}
