using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregn(2, 2);
            int res2 = Beregn(2, 2,2);
            int res3 = Beregn(2, 2,2,2);
            int res4 = Beregn(2,4,5,6);

            //Console.WriteLine("{0}\n{1}\n{2}",res,res2,res3);
            //Console.ReadKey();

            Console.WriteLine(res4);
            Console.ReadKey();
        }

        static int Beregn(int a, int b)
        {
            return a + b;
        }

        static int Beregn(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Beregn(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }


        //static int Beregn(int a, int b)
        // {
        //     return a + b;
        // }

        //static int Beregn(int a, int b, int c)
        // {
        //     return Beregn(a,b) + c;
        // }

        // static int Beregn(int a, int b, int c, int d)
        // {
        //     return Beregn(a,b,c) + d;
        // }
    }
}
