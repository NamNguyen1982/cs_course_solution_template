namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Kat k1;
            k1.Navn = "a";
            k1.Alder = 6;

            Kat k2;
            k2.Navn = "b";
            k2.Alder = 10;

            k1 = k2;

            k1.Alder = 100;

            Hund h1 = new Hund();
            h1.Navn = "x";
            h1.AntalBen = 3;

            Hund h2 = new Hund();
            h2.Navn = "y";
            h2.AntalBen = 10;

            h1 = h2;
            System.Console.WriteLine("{0} {1}", (string)h1.Navn, (int)h1.AntalBen);
            System.Console.WriteLine("{0} {1}", (string)h2.Navn, (int)h2.AntalBen);

            int[] månedsløn;

            månedsløn = new int[5];

            månedsløn[0] = 100;
            månedsløn[1] = 200;
            månedsløn[2] = 300;
            månedsløn[3] = 400;
            månedsløn[4] = 500;

            decimal gns2 = 0;

            for (int i = 0; i < månedsløn.Length; i++)
            {
                gns2 += månedsløn[i];
                gns2 = gns2 / månedsløn.Length;
                System.Console.WriteLine("resultat = " + gns2.ToString("n2"));
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        struct Kat
        {
            public string Navn;
            public int Alder;
        }

        class Hund
        {
            public string Navn;
            public int AntalBen;
         }
    }
}
