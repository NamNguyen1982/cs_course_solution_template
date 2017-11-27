using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment10Using
{
    class Program
    {
        static void Main(string[] args)
        {

            // without USING
            string url = @"X:\dyrenavne.txt";
            StreamReader stream = File.OpenText(@"X:\dyrenavne.txt");
            while (stream.Peek() != -1)
            {
                string navn = stream.ReadLine();
                Console.WriteLine(navn);
            }
            Console.ReadLine();
            stream.Close();
            stream = null;


            // with Using
            using (StreamReader stream2 = File.OpenText(@"X:\dyrenavne.txt"))
            {

                while (stream2.Peek() != -1)
                {
                    string navn = stream2.ReadLine();
                    Console.WriteLine(navn.ToUpper());
                    
                }
                Console.ReadLine();

            }
        }
    }
}
