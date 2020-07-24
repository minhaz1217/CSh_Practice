using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSh_Practice.Practice
{
    class _05_Exceptions_01
    {
        static double SafeDivision(double x, double y)
        {
            if(y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        public static void Run()
        {
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}/{1}.",x, y);
            try
            {
                double result = SafeDivision(x, y);
                Console.WriteLine("Result {0}", result);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally will reach regardless whether catch is invoked or not.");
            }

            Console.ReadKey();
        }
    }
}
