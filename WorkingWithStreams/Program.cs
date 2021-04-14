using System;
using System.IO;
using System.Xml;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace WorkingWithStreams
{
    class Program
    {

        static string[] callSigns = new string[] {
                "Husker", "Starbuck", "Apollo", "Boomer", "Bulldog", "Athena", "Helo", "Racetrack" };

        static void WorkWithText()
        {
            //define a file to write to
            string textFile = Combine(CurrentDirectory, "streams.txt");

            //create a text file and return a helpful writer
            StreamWriter text = File.CreateText(textFile);

            //enumerate the strings, writing each one to th stream on a separate line
            foreach (string item in callSigns)
            {
                text.WriteLine(item);
            }
            text.Close(); //release resources

            //output the contents of the file
            WriteLine($"{textFile} contains {new FileInfo(textFile).Length} bytes");
            WriteLine(File.ReadAllText(textFile));
        }
        static void Main(string[] args)
        {
            WorkWithText();
        }
    }
}