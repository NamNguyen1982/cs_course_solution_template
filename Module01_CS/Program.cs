namespace Module01_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Hello World hej dav");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
