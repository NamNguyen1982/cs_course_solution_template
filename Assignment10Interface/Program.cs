using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund h = new Hund();
            Ubåd u = new Ubåd();




            IDbFunktioner[] AntalObj = new IDbFunktioner[2];
            AntalObj[0] = h;
            AntalObj[1] = u;

            foreach (var item in AntalObj)
                item.Gem();
            Console.ReadLine();
        }
       
    }

}
