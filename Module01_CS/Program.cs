﻿namespace Module01_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Hello World" + " - " + "Ny linie") ;

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
