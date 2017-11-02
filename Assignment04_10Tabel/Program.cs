using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_10Tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 100;

            //for (int i = 0; i < 100; i++)
            //{

            //    for (int ital = 0; i <= x; ital++)
            //    {
            //        Console.Write(ital + " ");
            //    }


            //}



            /* --------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            // styrer x-aksen ( rækker ) op fra og ned
            for (int x = 1; x < 11; x++)
            {

                // styrer y-aksen ( kolonner )
                for (int y = 1; y < 11; y++)
                {
                    string tal = (x * y).ToString();

                    if ((y / x) == 1)
                    
                        Console.ForegroundColor = ConsoleColor.Green;
                        //Console.Write(tal.PadLeft(4));

                    

                    else if ((x * y) > 50)

                        Console.ForegroundColor = ConsoleColor.Red;
                    
                    else 

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(tal.PadLeft(4));

                

                    // Console.Write(tal.PadLeft(2));


                    //Console.Write(tal+" ");
                }
                Console.WriteLine();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
