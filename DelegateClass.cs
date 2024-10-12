using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public delegate void MyDelegate(int First, int Second);
    internal class DelegateClass
    {
        public static void Add(int First, int Second)
        {
            Console.WriteLine("Addition: "+(First + Second));
        }
        public static void Main(string[] args)
        {
            MyDelegate DelegateObj = new MyDelegate(Add);
            DelegateObj(6, 4);
        
        } 
    }
}
