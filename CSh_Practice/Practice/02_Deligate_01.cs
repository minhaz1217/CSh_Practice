using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSh_Practice.Practice
{
    class _02_Deligate_01
    {
        // delegate <return type> <delegate name> <parameter list>

        public delegate int Calculator(int a, int b);
        public int Add(int a, int b){
            Console.WriteLine("From add {0} {1}", a,b);
            return a + b;
        }
        public int Mul(int a, int b)
        {
            Console.WriteLine("From Mul {0} {1}", a, b);
            return a * b;
        }

        public static void CallCalculator(Calculator c)
        {
            Console.WriteLine(c(1, 2));
            Console.WriteLine(c(3, 44));
            Console.WriteLine(c(10, 20));
            Console.WriteLine(c(50,11));
        }

        public static void Run()
        {

            _02_Deligate_01 ob1 = new _02_Deligate_01();
            // basic usage of a delegate, we can assign function's as reference to it
            Calculator cl1 = new Calculator(ob1.Add);
            Console.WriteLine(cl1(2, 3));
            cl1 += ob1.Mul;
            Console.WriteLine(cl1(10, 10)); // delegate supports multicast, we can't realize it here, calling both add and mul function here.

            Calculator c2 = new Calculator(ob1.Add);
            //c2 += ob1.Add;
            _02_Deligate_01.CallCalculator(c2);
            //throw new NotImplementedException();
            Console.ReadKey();
        }
    }
}
