using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
   
    internal class VowelsConsonants
    {
        public static void CountVowels(string str)
        {
            int VowelCount = 0, ConsonantCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    VowelCount++;
                }
                else
                {
                    ConsonantCount++;
                }
            }
            Console.WriteLine("Count of Vowels:" + VowelCount);
            Console.WriteLine("Count of Consonents:" + ConsonantCount);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string MyString = Console.ReadLine();
            try
            {
               CountVowels(MyString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
