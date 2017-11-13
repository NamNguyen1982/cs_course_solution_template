using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //if (System.Diagnostics.Debugger.IsAttached)
            //{
            //    System.Console.Write("Press any key to continue . . . ");
            //    System.Console.ReadKey();
            //}

            Person p = new Person();
            string t = p.hej.ToString();
           
            Console.WriteLine(t);

            Console.ReadKey();


            Person p2 = new Person();
            Person p3 = new Person();

            p3 = null;

            string test = p2.ToString();
            Console.WriteLine(test);
            Console.ReadKey();

            // exception pga objectet er ikke eksisterende
            p2 = p3;
            Console.WriteLine(p2.ToString());
            Console.ReadKey();

            // Default Constructor - pga ingen argumenter / Custom Constructor hvis der er argumenter
            public Person()
            {
                Console.WriteLine("Nu bliver jeg født");
                
            }

        }


    }

    public class Person
    {

        public string hej;

    }

 



}
