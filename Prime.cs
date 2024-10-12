using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class Prime
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter a number to check whether it is a prime or not");
            int num=int.Parse(Console.ReadLine());
            if (num == 0 || num == 1)
            {
                Console.WriteLine($"Not able to define {num} is prime or not");
            }
            else if(num == 2 || num == 3)
            {
                Console.WriteLine($"{num} is prime number");
            }
            else if(num%2==0 || num % 3 == 0)
            {
                Console.WriteLine($"{num} is not a prime number");
            }
            else
            {
                for(int i = 5; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} is not a prime number");
                        return;
                    }
                }
                Console.WriteLine($"{num} is prime number");
            }
        } 
    }
}
