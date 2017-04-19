using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardGame
{
    public partial class Form1 : Form
    {

        
        Ball kulicka = new Ball(120, 120);
        Ball kulicka1 = new Ball(300, 150);

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;

            //test kulicky vektory
            kulicka.dx = 0.5;


            //background
            string background_path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "/graphics/table_background.png";
            this.gamefield.BackgroundImage = Image.FromFile(background_path);
        }

        private void gamefield_Click(object sender, EventArgs e)
        {

        }

        private void gamefield_Paint(object sender, PaintEventArgs e)
        {
            kulicka.DrawMe(e.Graphics);
            kulicka1.DrawMe(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kulicka.setDx(kulicka1);
            gamefield.Invalidate();

            this.textBox_dx.Text = kulicka.dx.ToString();
            this.textBox_dx1.Text = kulicka1.dx.ToString();

            // kulicka.circlesColliding(this.kulicka.X, this.kulicka.Y, 20, 120, 50, 20);
        }

        private void gamefield_MouseMove(object sender, MouseEventArgs e)
        {
            this.label_x.Text = e.X.ToString();
            this.label_y.Text = e.Y.ToString();
        }
    }
}
