using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04PlayingWithMyString
{
    class Program
    {
        static void Main(string[] args)
        {

            string forNavn      = "Nam";
            string efterNavn    = "Nguyen";
            string samletNavn = forNavn +  " "+ efterNavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string del = samletNavn.Substring(0,4);
            Console.WriteLine(del);

            string[] arNavn = samletNavn.Split(' ');
            for (int i = 0; i < arNavn.Length; i++)
            {
                Console.WriteLine(arNavn[i]);
            }


            string path = @"C:\Users\admin\Desktop\text.txt";
            string arConvert = arNavn[1].ToString();
            System.IO.File.WriteAllText(path, arConvert);

            string readText = System.IO.File.ReadAllText(path);

            Console.WriteLine(readText);





            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
    
}
