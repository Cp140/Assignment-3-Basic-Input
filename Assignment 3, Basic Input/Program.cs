using System;

namespace Assignment_3__Basic_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greetings
            string userName;
            int userAge;
            int currentYear;
            //Adder
            int intiger1;
            int intiger2;
            int intiger3;
            int intTotal;
            //Distance
            double dist1;
            double dist2;
            double dist3;
            double distAvg;
            //Hypotenuse

            //Greeting "Users name, Age, Current Year = age and year born in"
            Console.WriteLine("What's Your Name:");
            userName = Console.ReadLine();
            Console.WriteLine("What age are You:");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What year is it");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {userName} you were born in {currentYear - userAge}");
            //Adder of 3 random numbers
            Console.WriteLine("In put 3 random numbers");
            intiger1 = Convert.ToInt32(Console.ReadLine());
            intiger2 = Convert.ToInt32(Console.ReadLine());
            intiger3 = Convert.ToInt32(Console.ReadLine());
            intTotal = intiger1 + intiger2 + intiger3;
            Console.WriteLine(intTotal);
            //Distance Takes 3 Distances and Averages them
            Console.WriteLine("In put 3 random distances");
            dist1 = Convert.ToInt32(Console.ReadLine());
            dist2 = Convert.ToInt32(Console.ReadLine());
            dist3 = Convert.ToInt32(Console.ReadLine());
            distAvg = (dist1 + dist2 + dist3) / 3;
            Math.Round(distAvg, 2);
            Console.WriteLine(distAvg);
            //Hypotenuse Program reads two legs of right angle triangle, and gives length of hypotenuse.

        }
    }
}
