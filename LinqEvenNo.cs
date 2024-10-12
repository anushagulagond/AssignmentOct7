using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class LinqEvenNo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" list of Integers");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Add(11);
            list.Add(12);
            foreach(int item in list)
            {
                Console.Write(item+"  ");
            }
            Console.WriteLine();
            Console.WriteLine("List of even no from list using LINQ");
            var MyList = from ele in list
                         where ele % 2 == 0
                         select ele;
            foreach (int item in MyList)
            {
                Console.Write(item + "  ");
            }
                Console.WriteLine();
        }
    }
}
