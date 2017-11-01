namespace Module03_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // no go
            //int i = 50000000;
            //short j = i;

            //int i = 50000000;
            //short j = (short)i;


            int yy = 5000;
            //checked
            //{
            //    short uu = (short)yy;

            //}
            short uu = System.Convert.ToInt16(yy);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
