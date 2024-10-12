using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class Fibonacci
    {
        public static void FibonacciMethod(int Number)
        {
            int First = 0;
            int Second = 1;
            int Sum;
            if (Number > 0) {
                Console.WriteLine($"The Fibonacci series upto {Number} :");
                while (First <= Number)
                    {
                        Console.WriteLine(First);
                        Sum = First + Second;
                        First = Second;
                        Second = Sum;
                    }
            }
            else
            {
                throw new Exception();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get Fabonacci upto number");
            int num = int.Parse(Console.ReadLine());
            try
            {
                FibonacciMethod(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Number should be greater then 0");
            }
        }
    }
}
