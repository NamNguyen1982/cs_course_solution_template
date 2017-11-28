using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11GeneriskKlasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person1 p1 = new Person1();
            p1.Tilføj(new Instruktør());

            

        }
    }

    public class Person
    {

        public string ForNavn { get; set; }
        public string EfterNavn { get; set; }

        public int Alder { get; set; }
        public int Cpr { get; set; }

                

      }

    public class Instruktør : Person
{

        public int NøgleId { get; set; }
        public string KlasseVærelse { get; set; }

    }

    public class Kursist : Person
    {

        public int KursistId { get; set; }
        public int Timer { get; set; }
    }
    
    public class Person1
    {

        private List<Person> personer = new List<Person>();

        public void Tilføj(Person person)
        {
            personer.Add(person);

        }


       

    }


}
