using System; // DateTime
using System.Collections.Generic; //List<T> HashSet<T>
using System.Xml.Serialization; //XmlSerializer
using System.IO; // FileStream
using Packt.Shared;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace WorkingWithSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object graph
            var people = new List<Person>
            {
                new Person(30000M) { FirstName = "Alice", LastName = "Smith", DateOfBirth = new DateTime(1974, 3, 14) },
                new Person(40000M) { FirstName = "Bob", LastName = "Jones", DateOfBirth = new DateTime(1969, 11, 23) },
                new Person(20000M) { FirstName = "Charlie", LastName = "Cox", DateOfBirth = new DateTime(1984, 5, 4), Children = new HashSet<Person> {
                    new Person(0M) { FirstName = "Sally", LastName = "Cox", DateOfBirth = new DateTime(2000, 7, 12) } } }
            };

            // create an object that willformat a list of persons as XML
            var xs = new XmlSerializer(typeof(List<Person>));

            // create a file to write to
            string path = Combine(CurrentDirectory, "people.xml");

            using (FileStream stream = File.Create(path))
            {
                // serialize the object graph to the stream
                xs.Serialize(stream, people);
            }

            WriteLine($"Written {new FileInfo(path).Length} bytes of XML to {path}");

            // Display the serialized object graph
            WriteLine(File.ReadAllText(path));
        }
    }
}

namespace Packt.Shared
{
    public class Person
    {
        public Person() { }
        public Person(decimal initialSalary)
        {
            decimal Salary = initialSalary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public HashSet<Person> Children { get; set; }
        protected decimal Salary { get; set; }
    }
}