using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSh_Practice.Practice
{


    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
    class Counter2
    {
        private int threshold;
        private int total;
        public int Total
        {
            get { return total;  }
            set { total = value; }
        }
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;

        public Counter2(int val)
        {
            this.threshold = val;
        }
        
        public void Add(int x)
        {
            total += x;
            //Console.WriteLine("Adding {0}", this.total);
            if (total >= threshold)
            {

                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                //Console.Write("REACHED");
                OnThresholdReached(args);
            }

        }
        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = this.ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

    }


    class _04_Evvents_02
    {
       

        public static void Run()
        {
            Counter2 c = new Counter2(5);
            c.ThresholdReached += c_ThresholdReached;
            Console.WriteLine("press 'a' key to increase value:");

            while(Console.ReadLine().Trim() == "a")
            {
                c.Add(1);
                Console.WriteLine("Value increased, Current value {0}", c.Total);
            }

            Console.ReadKey();

        }
        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
            //Environment.Exit(0);

        }
    }
}
