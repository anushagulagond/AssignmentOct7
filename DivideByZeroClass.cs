using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class DivideByZeroClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to get divisible result");
            Console.WriteLine("Enter Numerator:");
            int Numerator=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Denominator:");
            int Denominator = int.Parse(Console.ReadLine());
            try
            {
                float Result = Numerator / Denominator;
                Console.WriteLine("Result: " + Result);
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("Number can't be divisible by zero");
            }
        }
    }
}
