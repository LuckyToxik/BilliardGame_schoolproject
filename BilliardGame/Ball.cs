using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardGame
{
    class Ball
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int radius { get; set; }

        public double dx { get; set; }

        public double dy { get; set; }

        public double mass { get; set; }



        public Ball(int x, int y)
        {
            this.radius = 20;
            this.mass = 0.5;
            this.X = x;
            this.Y = y;
            

        }

        public void DrawMe(Graphics g)
        {
            this.X += this.dx;
            this.Y += this.dy;

            g.FillEllipse(new SolidBrush(Color.Red), System.Convert.ToInt32(this.X) - radius, System.Convert.ToInt32(this.Y) - radius, 2 * radius, 2 * radius);
        }

        //HNUSOKÓD - refactoring!!
        public bool circlesColliding(int x1, int y1, int radius1, int x2, int y2, int radius2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int radii = radius1 + radius2;
            if ((dx * dx) + (dy * dy) < radii * radii)
                return true;
          


            return false;
        }


        //dopsat exceptions?? CHYBA VE VZORCI MAYBE?
        public void setDx(Ball ball)
        {
            if(circlesColliding(Convert.ToInt32(this.X), Convert.ToInt32(this.Y), this.radius, Convert.ToInt32(ball.X), Convert.ToInt32(ball.Y), ball.radius))
            {
                //výpočet celkové rychlosti obou těles po srážce

                double v = (this.mass * this.dx + ball.mass * ball.dx) / (this.mass + ball.mass);

                //získání souřadnice bababab X??? :)) deited - na +

                double vk1 = ball.mass * 1 * (this.dx - ball.dx) / (this.mass + ball.mass);
                double vk2 = this.mass * 1 * (this.dx - ball.dx) / (this.mass + ball.mass);

                this.dx = v - vk1;
                ball.dx = v + vk2;
            
                
            }
    


        }










        /*
            this.dx =dx* 0.9;
            this.dy = dy* 0.9;

            double newBall_x = (this.X + this.dx) * 0.9;
        double newBall_y = (this.Y + this.dy) * 0.9;


            if (newBall_x< 20+50 || newBall_x> 1280-20-55) dx = -dx;
            if (newBall_y< 20+62 || newBall_y> 720-20-65) dy = -dy;

            this.X += dx;
            this.Y += dy;



 
            */


    }
}


