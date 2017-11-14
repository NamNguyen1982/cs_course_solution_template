using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08ArvRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());
            Console.WriteLine();
            Console.ReadKey();

        }
    }


    class UdvidetRandom : System.Random
    {
        //Lav struct hvis der skal returneres 2 typer?
        public bool NextBool() {

            return this.Next(1, 1002) < 500 ;
        }

       
    }
}
