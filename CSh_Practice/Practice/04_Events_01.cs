using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSh_Practice.Practice
{


    class Counter 
    {
        private int threshhold;
        private int total;
        public event EventHandler ThresholdReached;

        public Counter(int passedThreshhold)
        {
            this.threshhold = passedThreshhold;
        }
        public void Add(int x)
        {
            total += x;
            if (total >= threshhold)
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }
        public int getTotal()
        {
            return this.total;
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }

        }
    }
    class _04_Events_01
    {

        /*
         * Event without any data, note the EventArgs.Empty parameter passed.
         * */
        public static void Run() 
        {

            Counter c = new Counter(new Random().Next(5));
            //c.ThresholdReached += c_ThresholdReached;
            Console.WriteLine("Current Total is {0}", c.getTotal());
            Console.WriteLine("Enter 'a' to increase total: ");
            while (Console.ReadKey(true).KeyChar == 'a') 
            {
                Console.WriteLine("Adding One {0}", c.getTotal());
                c.Add(1);
            }
            Console.ReadKey();
        }
    }
}
