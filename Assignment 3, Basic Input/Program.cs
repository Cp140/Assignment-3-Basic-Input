using System;

namespace Assignment_3__Basic_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int userAge;
            int currentYear;
            int intiger1;
            int integer2;
            int integer3;
            Console.WriteLine("What's Your Name:");
            userName = Console.ReadLine();
            Console.WriteLine("What age are You:");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What year is it");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {userName} you were born in {currentYear - userAge}");
            Console.WriteLine();
        }
    }
}
