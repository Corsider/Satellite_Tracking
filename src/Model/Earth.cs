using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Satellite_Tracking_Proj.Model
{
    public class Earth
    {
        public Controller.Controller controller { set; get; } = null;
        Random rand = new Random();
        public List<Satellite> satellites; //list of all satellites

        public Earth(Controller.Controller controller, Point center, Point ReceiverPosition)
        {
            this.controller = controller;
            this.satellites = new List<Satellite>();

            this.center = center;
            this.ReceiverPosition = ReceiverPosition;
            this.EarthPosition = new Point(center.X - 50, center.Y - 50);
            this.im = Resources.Resource1.earth_small2_test;
        }

        public Point center;
        public Point ReceiverPosition; // position of reciever point
        public Point EarthPosition; // EarthPosition
        public Image im;
    }
}
