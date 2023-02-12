using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Satellite_Tracking_Proj.Model
{
    public class Satellite
    {
        public Earth earth { set; get; }

        public Point loc;
        /*========= for intersecting orbits */
        public Point tmpPonit;
        /*=========*/
        int x, y; // start position
        double coord_x, coord_y;
        public double r; // radius-vector
        public double r_vector;
        // ***********
        public double r_track;
        public int sat_stat;
        public bool ReceiverSign = true; // true - for increasing x (+), false - .;. (-)
        public double ReceiverBias;
        public bool VisibleReceiverFlag = true;
        public Orbit orbit = null;
        /*-------------*/
        public double velo_coef; // коэфф скорости 
        public int size;
        /*-------------*/
        Random rand = new Random();
        public Point loc_begin;
        public int sign; // направл вращения 

        public Satellite(Point center, Point ReceiverPosition)
        {
            this.tmpPonit = new Point();
            this.orbit = new Orbit(center, ReceiverPosition);
            loc_begin = new Point();
            start_position();
            this.orbit.center = center;
            this.orbit.ReceiverPosition = ReceiverPosition;
            loc_begin = loc;
            sign = rand.Next(0, 100);
            velo_coef = 1;
            size = 4;
        }

        public void UpdateOrbit(Point cent, Point npos)
        {
            this.orbit.center = cent;
            this.orbit.ReceiverPosition = npos;
        }

        public void start_position()
        {
            this.coord_x = orbit.b * Math.Cos(orbit.angle_rotation);
            this.coord_y = orbit.a * Math.Sin(orbit.angle_rotation);
            // rotating x and y
            Calculation.rotation(ref coord_x, ref coord_y, orbit.angle);

            this.x = (int)(orbit.center.X + coord_x);
            this.y = (int)(orbit.center.Y + coord_y);

            this.loc = new Point(x - size, y - size); // default location
        }

        public void position() // position every tick
        {
            this.coord_x = orbit.b * Math.Cos(orbit.angle_rotation);
            this.coord_y = orbit.a * Math.Sin(orbit.angle_rotation);
            // rotating x and y
            Calculation.rotation(ref coord_x, ref coord_y, orbit.angle);
            this.x = (int)(orbit.center.X + coord_x);
            this.y = (int)(orbit.center.Y + coord_y);
            this.loc = new Point(x - size, y - size);

            // calc radius-vector to reciever
            r_track = Calculation.radius_vector(loc, orbit.ReceiverPosition);
            double del_x, del_y;
            del_x = loc.X - orbit.center.X;
            del_y = loc.Y - orbit.center.Y;
            r = Math.Sqrt(Math.Pow(del_x, 2) + Math.Pow(del_y, 2)); // нашли гипотенузу
        }

        public void angle_change(Point loc)
        {
            if (sign > 50)
            {
                orbit.angle_rotation -= 0.01 * velo_coef;
            }
            else
            {
                orbit.angle_rotation += 0.01 * velo_coef;
            }
            Task.Delay(1);

            /* sign settings for reciever position */
            if (ReceiverSign == true)
            {
                this.ReceiverBias += 0.005;
            }
            else
            {
                this.ReceiverBias -= 0.005;
            }
            //for intersecting orbits
            this.tmpPonit = loc;
        }
    }
}
