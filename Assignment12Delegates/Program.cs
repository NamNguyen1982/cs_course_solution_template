using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12Delegates
{
    class Program
    {

        public delegate int Beregn(int a, int b);

        static void Main(string[] args)
        {

            
            int res = Beregner(3,2,Plus);
            Console.WriteLine("Result:" + " " + res);
            res = Beregner(3, 2, Minus);
            //res += Minus();
            
            Console.WriteLine("Result:" + " " + res);
            Console.ReadLine();

            Console.WriteLine(Beregner(5,5,Minus));
            Console.ReadLine();
        }

        public static int Beregner(int a , int b, Beregn funk) {

            return funk(a, b);

        }

        public static int Plus(int a, int b) {

            return a + b;
        }
        public static int Minus(int a, int b) {


            return a - b;
        }
        public static int Divider(int a, int b) {

            return a / b;
        }
        public static int Gange(int a, int b) {

            return a * b;
        }

    }

    
}
