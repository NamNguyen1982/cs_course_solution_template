using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04DiffClassAndStruct
{
    class Program
    {
        static void Main(string[] args)
        {


            Person k1 = new Person();
            Person k2 = new Person();

            k1.navn = "a";
            k2.navn = "b";

            // struct - udskriver a , b
            // class - udskriver a, b - fordi k1 og k2 peger på hver deres Person object.
            Console.WriteLine("{0} {1}",k1.navn,k2.navn);

            k1 = k2;

            // struct - udskriver b , b - fordi at k1.navn bliver overskrevet af k2.navn
            // class - udskriver b, b - fordi at k1.navn og k2.navn peger på samme object ( k1 objectet bliver droppet/forsvinder)
            Console.WriteLine("{0} {1}", k1.navn, k2.navn);


            k1.navn = "c";

            // struct - udskriver c , b - fordi at k1.navn bliver sat til c
            // class - udskriver c, c - fordi at elementet "navn" i objectet Person (i heap) bliver ændret til "c" og begge variabler peger stadigvæk på samme object 
            Console.WriteLine("{0} {1}", k1.navn, k2.navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }


    //struct Person
    //{
    //    public string navn;
    //}
    class Person
    {
        public string navn;

    }



}
