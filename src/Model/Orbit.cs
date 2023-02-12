using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satellite_Tracking_Proj.Model
{
    public class Orbit
    {
        int angle_min = 0;
        int angle_max = 180;
        int rad_min = 52;
        int rad_max = 150;

        public int a = 150;
        public int b;
        public int min_b = 0;
        public double angle;
        //
        public Point center;
        public Point ReceiverPosition;
        //
        public double angle_rotation;
        public double angleStart;
        public double angle_deg;

        /*=========*/
        public Point apogee_1; //верхний(левый) и 
        public Point apogee_2; //нижний(правый)
        /*=========*/

        Random rand = new Random();
        public Orbit(Point center, Point ReceiverPosition)
        {
            random_orbit();
            this.angle_deg = angle;
            Calculation.rad_to_deg(ref angle_deg);
        }

        public void random_orbit()
        {
            //задаем слачайные радиусы эллипсов и углы
            this.b = rand.Next(rad_min, rad_max);
            this.angle = rand.Next(angle_min, angle_max); // 
            this.angle = this.angle * Math.PI / 180.0; // 0 .. pi
        }
    }
}
