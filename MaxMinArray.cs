using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class MaxMinArray
    {
        public static int MaxElementMethod(int[] arr)
        {
            int MaxElement = arr[0];
            foreach(int ele in arr)
            {
                if (MaxElement < ele)
                {
                    MaxElement = ele;
                }
            }
            return MaxElement;
        }
        public static int MinElementMethod(int[] arr)
        {
            int MinElement = arr[0];
            foreach (int ele in arr)
            {
                if (MinElement > ele)
                {
                    MinElement = ele;
                }
            }
            return MinElement;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter array size :");
            int size=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter array elements of {size} size");
            int[] MyArray=new int[size];
            for(int i = 0; i < size; i++)
            {
                MyArray[i]=int.Parse(Console.ReadLine());
            }
            int MaxElement= MaxElementMethod(MyArray);
            Console.WriteLine("Maximum element in MyArray: "+MaxElement);
            int MinElement = MinElementMethod(MyArray);
            Console.WriteLine("Minimum element in MyArray: " + MinElement);

        }
    }
}
