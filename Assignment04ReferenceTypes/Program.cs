using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialiserer Array
            int[] månedsløn;

            månedsløn = new int[12];

            månedsløn[0] = 100;
            månedsløn[1] = 200;
            månedsløn[2] = 300;
            månedsløn[3] = 400;
            månedsløn[4] = 500;
            månedsløn[5] = 600;
            månedsløn[6] = 700;
            månedsløn[7] = 800;
            månedsløn[8] = 900;
            månedsløn[9] = 1000;
            månedsløn[10] = 1100;
            månedsløn[11] = 1200;


            var sum = månedsløn.Average();

            Console.WriteLine("sum: "+sum);


            foreach (int i in månedsløn)
            {

                Console.WriteLine("number {0}",i);

            
            }




            for (int i = 0; i < månedsløn.Length; i++)
            {

                // udskriver i oprindelig orden
                int beløb = månedsløn[i];
                System.Console.WriteLine("Denne måned har du fået= " + beløb);


            }

            // Reverse metode benyttes
            Array.Reverse(månedsløn);

            for (int i = 0; i < månedsløn.Length; i++)
            {

                //udskriver i omvendt rækkefølge
                int beløb = månedsløn[i];
                System.Console.WriteLine("Denne måned har du fået= " + beløb);

            }

            //sorterer array elementer efter ascending
            Array.Sort(månedsløn);


            for (int i = 0; i < månedsløn.Length; i++)
            {

                //udskriver oprindelig rækkefølge
                int beløb = månedsløn[i];
                System.Console.WriteLine("Denne måned har du fået= " + beløb);


            }

            Array.Resize(ref månedsløn, 13);

            månedsløn[12] = 12;

            for (int i = 0; i < månedsløn.Length; i++)
            {

                //udskriver oprindelig rækkefølge
                int beløb = månedsløn[i];
                System.Console.WriteLine("Denne måned har du fået= " + beløb);


            }




            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
 


    }
}
