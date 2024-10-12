using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class SumArray
    {
        public static int SumOfArrayElementsMethod(int[] array)
        {
            int Sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Sum += array[i];
            }
            return Sum;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter array size :");
            int size1 = int.Parse(Console.ReadLine());
            int[] MyArray1 = new int[size1];
            try
            {
                if (size1 > 0)
                {
                    Console.WriteLine($"Enter array1 elements of {size1} size in sorted manner");
                    for (int i = 0; i < size1; i++)
                    {
                        MyArray1[i] = int.Parse(Console.ReadLine());
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int SumOfArrayElements = SumOfArrayElementsMethod(MyArray1);
            Console.WriteLine("Sum of Array Elements: "+SumOfArrayElements);
        }
    }
}
