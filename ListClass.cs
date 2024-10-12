using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class ListClass
    {
        public static void Main(string[] args) { 
        List<int> list = new List<int>();
            list.Add(20);
            list.Add(22);
            list.Add(9);
            list.Add(10);
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            Console.WriteLine("all elements of list");
            foreach (int item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
             Console.WriteLine("Even elements of list");
            foreach (int item in list)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item+" ");
                }
            }
         }
    }
}
