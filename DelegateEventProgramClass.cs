using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class Counter
    {
        private int count;
        public int Threshould { get; set; }

        public delegate void ThreshouldReachedEventHandler(Object sender, EventArgs e);
        public event ThreshouldReachedEventHandler ThreshouldReached;
        public Counter(int Thresould)
        {
            this.Threshould = Thresould;
        }
        public void Increment()
        {
            count++;

            if (count == Threshould)
            {
                OnThreshouldReached();
            }
        }
        public virtual void OnThreshouldReached()
        {
           ThreshouldReached?.Invoke(this,EventArgs.Empty);
        }
    }
    public class EventHandler
    {
        public EventHandler(Counter counter) {
            counter.ThreshouldReached += Counter_ThreshouldReached;
        }
        public void Counter_ThreshouldReached(Object sender,EventArgs e)
        {
            Console.WriteLine("Threshould Reached!");
        }
    }
    internal class DelegateEventProgramClass
    {
        public static void Main(string[] args)
        {
            Counter counter = new Counter(10);
            EventHandler handler = new EventHandler(counter);

            for(int i = 0; i <15; i++)
            {
                Console.WriteLine($"Count: {i+1}");
                counter.Increment();
            }
        }
    }
}
