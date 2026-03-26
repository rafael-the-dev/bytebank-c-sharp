

namespace Module.Entities
{
    abstract class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            this.Color = color;
        }

        public abstract double Area();
    }
}