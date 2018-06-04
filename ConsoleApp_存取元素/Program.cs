using System;
using System.Linq;

namespace ConsoleApp_存取元素
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLastItems = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string firstContainsO = firstLastItems.First(s => s.Contains('o'));
            string lastContainsO = firstLastItems.Last(s => s.Contains('o'));

            Console.WriteLine($"First string starting with 'o':{firstContainsO}");
            Console.WriteLine($"Last string starting with 'o':{lastContainsO}");
            Console.Read();
        }
    }
}
