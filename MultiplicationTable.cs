using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class MultiplicationTable
    {
        public static void MultipleTableMethod(int Number)
        {
            if (Number <= 0)
            {
                throw new Exception();
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(Number +"* "+ i +" = "+Number*i);
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number which you can get its multiple table");
            int num = int.Parse(Console.ReadLine());
            try
            {
                MultipleTableMethod(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Number is not eligible of its multiplication table");
            }
        }
    }
}
