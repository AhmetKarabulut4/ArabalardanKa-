using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Right)
                {
                    sağ.Enabled = true;
                    sol.Enabled = false;
                }

                if (e.KeyCode == Keys.Left)
                {
                    sağ.Enabled = false;
                    sol.Enabled = true;

                
            }
        }

        private void sol_Tick(object sender, EventArgs e)
        {
            pictureBox5.Left -= 10;
            if (pictureBox5.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
        }

        private void sağ_Tick(object sender, EventArgs e)
        {
            pictureBox5.Left += 10;
            if (pictureBox5.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                sol.Enabled = false;
                sağ.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                pictureBox9.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;


            if (pictureBox1.Top >= 650)
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(0, 2);
                switch (rastgele)
                {
                    case 0:
                        {
                            timer3.Enabled = true;
                            timer4.Enabled = true;
                            timer5.Enabled = false;
                        }
                        break;
                    case 1:
                        {
                            timer3.Enabled = true;
                            timer4.Enabled = true;
                            timer5.Enabled = false;
                        }
                        break;

                }
                pictureBox1.Top = 33;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top += 10;

            if (pictureBox2.Top >= 650)
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(0, 2);
                switch (rastgele)
                {
                    case 0:
                        {
                            timer3.Enabled = false;
                            timer4.Enabled = true;
                            timer5.Enabled = true;
                        }
                        break;
                    case 1:
                        {
                            timer3.Enabled = false;
                            timer4.Enabled = true;
                            timer5.Enabled = true;
                        }
                        break;

                }
                pictureBox2.Top = 33;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox4.Top += 10;

            if (pictureBox4.Top >= 650)
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(0, 2);
                switch (rastgele)
                {
                    case 0:
                        {
                            timer3.Enabled = true;
                            timer4.Enabled = false;
                            timer5.Enabled = true;
                        }
                        break;
                    case 1:
                        {
                            timer3.Enabled = true;
                            timer4.Enabled = false;
                            timer5.Enabled = true;
                        }
                        break;

                }
                pictureBox3.Top = 33;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            pictureBox8.Visible = false;
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}