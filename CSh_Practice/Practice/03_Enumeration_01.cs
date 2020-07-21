using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSh_Practice.Practice
{
    class _03_Enumeration_01
    {

        enum WeekDays
        {
            Satarday,
            Sunday,
            Monday,
            Tuesday=10,
            Wednesday,
            Thursday,
            Friday=-1
        }
        public static void Run()
        {
            Console.WriteLine(WeekDays.Satarday);
            Console.WriteLine((int)WeekDays.Satarday);
            Console.WriteLine((WeekDays)0);
            Console.WriteLine((WeekDays)10);
            Console.WriteLine((WeekDays)11);
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.ReadKey();

        }
    }
}
