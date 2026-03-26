

namespace Module.Entities
{
    class Rectangle : Shape
    {
        public double width {  get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height, string color) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
