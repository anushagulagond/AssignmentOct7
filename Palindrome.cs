using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class Palindrome
    {
        public static void CheckPalindrome(string str)
        {
            int left = 0, right = str.Length-1;
            while (left < right)
            {
                if (str[left] == str[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    Console.WriteLine($"{str} is not a Palindrome");
                    return;
                }
            }
            Console.WriteLine($"{str} is a Palindrome");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String to check Palindrome or not:");
            string MyString = Console.ReadLine();
            try {
                CheckPalindrome(MyString);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
