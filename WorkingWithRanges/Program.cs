using System;

namespace WorkingWithRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Samantha Jones";

            int lengthOfFirst = name.IndexOf(' ');
            int lengthOfLast = name.Length - lengthOfFirst - 1;

            string firstName = name.Substring(0, lengthOfFirst);
            string lastName = name.Substring(name.Length - lengthOfLast, lengthOfLast);

            Console.WriteLine($"First name: {firstName}, Last name: {lastName}");

            ReadOnlySpan<char> nameAsSpan = name.AsSpan();

            var firstNameSpan = nameAsSpan[0..lengthOfFirst];

            var lastNameSpan = nameAsSpan[^lengthOfLast..^0];

            Console.WriteLine($"First name: {firstNameSpan.ToString()}, Last name: {lastNameSpan.ToString()}");
        }
    }
}
