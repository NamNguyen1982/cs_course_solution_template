using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12Delegates
{
    class Program
    {
        //Func<int,int,be>;
        //public delegate int Beregn(int a, int b);

        static void Main(string[] args)
        {

            //Beregn b1 = new Beregn(Beregner);
            //b1 = Plus;
            //b1 += Minus;

            //b1(5,5);
            int res = 0;
            //Console.WriteLine("Result:" + " " + res);
           // Console.WriteLine();
            //int res = Beregner(3,2,Plus);
            //Console.WriteLine("Result:" + " " + res);
            //res = Beregner(3, 2, Minus);
            Console.WriteLine("Result:" + " " + (res = Beregner(3, 2, Gange)));
            Console.WriteLine("Result:" + " " + (res = Beregner(3, 2, Divider)));
            Console.WriteLine("Result:" + " " + (res = Beregner(3, 2, Plus)));
            Console.WriteLine("Result:" + " " + (res = Beregner(3, 2, Minus)));


            Console.WriteLine(Beregner(1,2,(a, b) => (a / b)));



           // Console.WriteLine(1,2,5,(a,b,c) => a / b*c);
            //res += Minus();

            //Console.WriteLine("Result:" + " " + res);
            //Console.ReadLine();

            //Console.WriteLine(Beregner(5,5,Minus));
            Console.ReadLine();
        }

        public static int Beregner(int a, int b, Func<int,int,int> funk)
        {

            return funk(a, b);

        }

        // Func<int,int,Beregn>

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
