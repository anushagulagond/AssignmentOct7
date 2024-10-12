using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace AssignmentOct7
{
    internal class ReverseArray
    {
        public static int[] ReverseArrayMethod(int[] array)
        {
            int[] result = new int[array.Length];
            int Iterator = 0;
            for (int i = array.Length - 1; i >= 0; i--)
               {
                 result[Iterator] = array[i];
                 Iterator++;
               }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter array size :");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter array elements of {size} size");
            int[] MyArray = new int[size];
            try
            {
                if (MyArray.Length > 0)
                {
                for (int i = 0; i < size; i++)
                {
                    MyArray[i] = int.Parse(Console.ReadLine());
                }
                    Console.WriteLine("Reverse of an Array:");
                    int[] ResultArray = ReverseArrayMethod(MyArray);
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(ResultArray[i] + " ");
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

    }
}
