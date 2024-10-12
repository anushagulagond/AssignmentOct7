using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class MergeSortedArray
    {
        public static int[] MergeSortedArrayMethod(int[] array1, int[] array2)
        {
            int[] ResultArray= new int[array1.Length+array2.Length];
            int Iterator = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                ResultArray[Iterator++] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                ResultArray[Iterator++] = array2[i];
            }
            for(int i = 0; i < ResultArray.Length; i++){
                for(int j = i + 1; j < ResultArray.Length; j++)
                {
                    if (ResultArray[i] > ResultArray[j])
                    {
                        int temp=ResultArray[i];
                        ResultArray[i]=ResultArray[j];
                        ResultArray[j]=temp;
                    }
                }
            }
            return ResultArray;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter array1 size :");
            int size1 = int.Parse(Console.ReadLine());
            int[] MyArray1 = new int[size1];
            Console.WriteLine("Enter array2 size :");
            int size2 = int.Parse(Console.ReadLine());
            int[] MyArray2 = new int[size2];

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

                if (size2 > 0)
                {
                    Console.WriteLine($"Enter array2 elements of {size2} size in sorted manner");
                    for (int i = 0; i < size2; i++)
                    {
                        MyArray2[i] = int.Parse(Console.ReadLine());
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
            int[] ResultArray = MergeSortedArrayMethod(MyArray1, MyArray2);//new int[size1 + size2];
            Console.WriteLine("Merged elements from two arrays:");
            for (int i = 0; i < ResultArray.Length; i++)
            {
                Console.Write(ResultArray[i] + " ");
            }
        }
    }
}
