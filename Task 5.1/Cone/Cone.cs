using System;

namespace Cone
{
    public class Cone
    {
        private double Radius { get; set; }
        private double Height { get; set; }

        public Cone(double r, double h)
        {
            Radius = r;
            Height = h;
        }

        public double FindBaseSquare()
        {
            double s = (Math.PI * Math.Pow(Radius, 2));
            
            return s;
        }

        public double FindFullSquare()
        {
            double s = (Math.PI * Math.Pow(Radius, 2) + Math.PI * Radius * Math.Sqrt(Radius * Radius + Height * Height));

            return s;
        }
    }
}
