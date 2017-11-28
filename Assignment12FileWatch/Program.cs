using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment12FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {


            FileSystemWatcher w = new FileSystemWatcher(@"C:\temp");//, "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size;
            w.Changed += E_Chaned;
            w.Created += E_Created;

            do
            {

            } while (true);

               


        }

        private static void E_Chaned(object sender, FileSystemEventArgs e)
        {

            Console.WriteLine(e.Name);

        }
        private static void E_Created(object sender, FileSystemEventArgs e)
        {

            Console.WriteLine(e.Name);
        }


    }
}
