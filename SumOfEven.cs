using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class SumOfEven
    {
        public static void SumOfEvenMethod(int Number)
        {
            if (Number <= 0)
            {
                throw new Exception();
            }
            else
            {
                int Sum = 0;
                for (int i = 1; i < Number; i++)
                {
                    if (i % 2 == 0)
                    {
                        Sum += i;
                    }
                }
                Console.WriteLine("Sum of Even Numbers is:" + Sum);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get Sum of Even number from 1 to num");
            int num = int.Parse(Console.ReadLine());
            try
            {
                SumOfEvenMethod(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Number should be greater then 0");
            }
        }
    }
}
