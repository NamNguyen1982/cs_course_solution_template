using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> p = new List<Person>();

            p.Add(new Person { Id = 1, Navn = "Nam" });
            p.Add(new Person { Id = 2, Navn = "Bent" });
            p.Add(new Person { Id = 3, Navn = "Chris" });


            foreach (var item in p)
            {
                Console.WriteLine(item.Navn);
            }
            Console.ReadLine();


            Dictionary<int, Person> lst = new Dictionary<int, Person>();

            lst.Add(1,new Person {Id = 10, Navn = "Balu" });
            lst.Add(2, new Person { Id = 20, Navn = "Dennis" });
            lst.Add(3, new Person { Id = 30, Navn = "Yoko" });
            var d = lst[2];
            Console.WriteLine(d.Navn);
            Console.ReadLine();

            foreach (var item in lst)
            {
                Console.WriteLine(item.Value.Navn);
            }

            Console.ReadLine();
        }
    }


    class Person
    {

        public int Id { get; set; }

        public string Navn { get; set; }

    }
}
