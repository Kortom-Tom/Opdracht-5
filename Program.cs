using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1900; i < 2020; i++)

            Console.WriteLine("{0} is schrikkeljaar: {1}", i, DateTime.IsLeapYear(i));
            Console.ReadKey();

        }

    }
}