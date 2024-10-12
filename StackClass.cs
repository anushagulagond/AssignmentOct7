using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class Stack
    {
        public int[] MyArray;
        public int Top;
        public int MaxSize;

        public Stack(int size)
        {
            MyArray = new int[size];
            Top = -1;
            MaxSize = size;

        }
        public void Push(int Value)
        {
            if (Top < MaxSize - 1)
            {
                Top++;
                MyArray[Top] = Value;
            }
            else
            {
                Console.WriteLine("Stack Overflow");
            }
        }
        public int Pop()
        {
            if (MyArray.Length <= 0)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Popped Value: " + MyArray[Top]);
                Top--;
                return MyArray[Top + 1];
            }
        }
        public int Peek()
        {
            if (Top >= 0)
            {
                return MyArray[Top];
            }
            else
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }
        }
        public Boolean IsEmpty()
        {
            return Top == -1;
        }
        public Boolean IsFull()
        {
            return Top == MaxSize-1;
        }
    }
    internal class StackClass
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of stack");
            int size=int.Parse(Console.ReadLine());
            Stack stack = new Stack(size);
            Console.WriteLine($"Enter {size} elements to push into stack");
            for(int i = 0; i < size; i++) 
                {
                    stack.Push(int.Parse(Console.ReadLine()));
                }
                Console.WriteLine(stack.Peek());
                Console.WriteLine("stack.IsFull "+stack.IsFull());
                 stack.Pop();
                Console.WriteLine("stack.IsEmpty "+stack.IsEmpty());

        }
    }
}
