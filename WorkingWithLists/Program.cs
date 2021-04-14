using System;
using static System.Console;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");
            WriteLine("Initial List");
            foreach (string city in cities)
            {
                WriteLine($" {city}");
            }

            WriteLine($"The first city in {cities[0]}");
            WriteLine($"The last city is {cities[cities.Count - 1]}.");

            cities.Insert(0, "Sydney");

            WriteLine("After inserting Sydney at index 0");
            foreach (string city in cities)
            {
                WriteLine($" {city}");
            }

            cities.RemoveAt(1);
            cities.Remove("Milan");

            WriteLine("After removing two cities");
            foreach (string city in cities)
            {
                WriteLine($" {city}");
            }

            var immutableCities = cities.ToImmutableList();

            var newList = immutableCities.Add("Rio");

            Write("Immutable list of cities:");
            foreach (string city in immutableCities)
            {
                Write($" {city}");
            }

            WriteLine();

            Write("New list of cities:");
            foreach (string city in newList)
            {
                Write($" {city}");
            }
            WriteLine();

            var i1 = new Index(3);
            Index i2 = 3;
            var i3 = new Index(5, true);
            var i4 = ^5;

            WriteLine(i1);
        }
    }
}
