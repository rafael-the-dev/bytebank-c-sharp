using System;
using System.Globalization;

using Module.Entities;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            sbyte n = sbyte.Parse(Console.ReadLine());

            for (sbyte i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");

                Console.Write("Rectangle or Circle(r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                string color = Console.ReadLine();

                if (ch == 'r')
                {
                    Console.Write("Enter width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Enter height: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(width, height, color));
                }
                else if (ch == 'c')
                {
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPES AREAS");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}