
using System;

namespace Module.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string color) : base(color)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Radius * Math.Pow(Radius, 2);
        }
    }
}
