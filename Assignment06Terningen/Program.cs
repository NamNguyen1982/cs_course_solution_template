using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06Terningen
{
    class Program
    {
        static void Main(string[] args)
        {

            Terningen t1 = new Terningen();
            t1.Skriv();
            
            t1.Ryst();
            t1.Skriv();
            Console.ReadKey();



            //Terningen t2 = new Terningen(true);
            //t2.Skriv();

            //t2.Ryst();
            //t2.Skriv();
            //Console.ReadKey();
        }

    }
}
