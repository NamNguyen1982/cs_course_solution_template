using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09SimpleFejlhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {

            Run();

        }


        private static void Run() 
        {
            try
            {

                Console.WriteLine("Indtast 1. tal");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast 2. tal");
                int tal2 = Convert.ToInt32(Console.ReadLine());

                int res = tal1 + tal2;
                Console.WriteLine("Resultatet er : " + res);
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Du må kun indtaste et tal - Tryk [Y] for at prøve igen.... ");
                
                string tast = Console.ReadLine().ToUpper();

                

                if (tast == "Y")
                {
                    Run();
                }

                else
                    Console.WriteLine(ex);
                Console.ReadKey();
            }


        }
    }



    

}
