using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();

            p.Name = "Nam";
            p.Surname = "Nguyen";



            Console.WriteLine(p.FullName());
            Console.ReadKey();

            Elev e = new Elev();
            e.Name = "Mogen";
            e.Surname = "Mogensen";
           

            Console.WriteLine(e.FullName());
            Console.ReadKey();

            Instruktør i = new Instruktør() {Name = "Hans" , Surname = "Hansen",Skema = "MAAAANDAG"};


            Console.WriteLine(i.NameAndSkema());
            Console.ReadKey();

        }



        public class Person {

            public string Name { get; set; }

            public string Surname { get; set; }

            public string FullName() {

                return Name + " " + Surname;

            }

            public Person()
            {

            }


        }

        public class Elev : Person
        {

            public string Klasselokale { get; set; }

            public Elev()
            {

            }

        }



        

        public class Instruktør : Person
        {

            public int NøgleId { get; set; }
            public string Skema { get; set; }
            public string NameAndSkema() {

                return Skema + "\n" + FullName();

            }
        }
    }
}
