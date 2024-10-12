using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{ 
    internal class ReverseWords
    {
        public static void ReverseWordsMethod(string str)
        {
            if (str == null) { 
                throw new ArgumentNullException("str");
            }
            else
            {
                string[] array = str.Split(' ');
                for(int i = array.Length-1; i >=0;i--)
                {
                    Console.Write(array[i]+" ");
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String to make words in reverse");
            string MyString = Console.ReadLine();
            try
            {
                ReverseWordsMethod(MyString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
