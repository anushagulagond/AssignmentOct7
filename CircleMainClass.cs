using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class Circle
    {
        public float Radius { get; set; }
        public Circle(float Radius)
        {
            this.Radius = Radius;
        }
        ~Circle()
        {
            Console.WriteLine("Object is Destroyed");
        }
        public float Area()
        {
            return (22 / 7f) * Radius * Radius;
        }
        public float Perimeter()
        {
            return 2 * (22 / 7f) * Radius;
        }

    }
    public class CircleMainClass
    {
        public static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            try
            {
                if (circle1.Radius > 0)
                {
                    float AreaResult = circle1.Area();
                    Console.WriteLine("Area of Circle: " + AreaResult);
                    float PerimeterResult = circle1.Perimeter();
                    Console.WriteLine("Perimeter of Circle: " + PerimeterResult);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Radius should be greater then zero");
            }
            finally
            {
                circle1 = null;
                GC.Collect();
            }
        }
    }
}
