using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("Dont know which shape");
        }
    }
    public class CircleShape : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Enter radius of Circle: ");
            int Radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Circle: " + 2 * (22f / 7) * Radius);
        }
    }
    public class RectangleShape : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Enter Length of Rectangle: ");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Length of Rectangle: ");
            int Breadth = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Rectangle: " + Length*Breadth);
        }
    }
    public class TriangleShape : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Enter Base of Rectangle: ");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height of Rectangle: ");
            int Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Rectangle: " + (1/2f)*Base*Height);
        }
    }
    internal class ShapeInheritanceClass
    {
        public static void Main(string[] args)
        {
            CircleShape circle = new CircleShape();
            circle.Area();
            RectangleShape rectangleShape = new RectangleShape();
            rectangleShape.Area();
            TriangleShape triangleShape = new TriangleShape();
                triangleShape.Area();
        }
    }
}
