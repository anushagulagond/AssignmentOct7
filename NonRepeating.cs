using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentOct7
{
    internal class NonRepeating
    {
        public static void NonRepeatingCharacter(string str)
        {
            int[] array = new int[128];
            for(int i = 0; i < str.Length; i++)
            {
                array[str[i]]++;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (array[str[i]] == 1)
                {
                    Console.WriteLine("First non repeating char:"+str[i]);
                    return;
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string MyString = Console.ReadLine();
            try
            {
                NonRepeatingCharacter(MyString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
