using System;
using System.Collections.Generic;

namespace WorkingWithDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var keywords = new Dictionary<string, string>();
            keywords.Add("int", "egwe");
            keywords.Add("long", "egwrgwer");
            keywords.Add("float", "wergww");

            foreach (KeyValuePair<string, string> item in keywords)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

            var foo = new Dictionary<string, string>() { { "rgg", "wgwg" } };

            var bob = new Person("Gino", DateTime.Now);
            
            Console.WriteLine(bob.DateOfBirth);
            bob.Big();


        }

        public class Person
        {
            public string Name;
            public DateTime DateOfBirth;

            private string favoriteIceCream;
            public string FavoriteIceCream { get; set; }

            public Person(string name, DateTime dateOfBirth)
            {
                Name = name;
                DateOfBirth = dateOfBirth;
            }

            public void Big() {
                Console.WriteLine(FavoriteIceCream);
            }
        }

    }
}
