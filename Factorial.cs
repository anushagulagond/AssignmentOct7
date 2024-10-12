using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class Factorial
    {
        public static long Fact(int num)
        {
            long Product = 1;
            for(int i = 1; i <= num; i++)
            {
                Product = Product * i;
            }
            return Product;
        //Using recursion
        //    if (num == 1)
        //    {
        //        return 1;
        //    }
        //    if (num == 2)
        //    {
        //        return 2;
        //    }
        //    else
        //    {
        //        return num * Fact(num - 1);
        //    }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number to get Factorial");
            int number=int.Parse(Console.ReadLine());
            long result=Fact(number);
            Console.WriteLine($"Factorial of {number} is {result}");
        }
    }
}
