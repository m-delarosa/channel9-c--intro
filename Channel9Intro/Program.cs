using System;
using System.Collections.Generic;

namespace Channel9Intro
{
    struct Person
    {
        public string name;
        public string eyeColor;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }
        static void FibbonaciNumbers()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count <= 19)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                int sum = previous + previous2;
                fibonacciNumbers.Add(sum);
            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
        static void PrintingAndParsing()
        {
            bool a = true;
            int b = 10;
            double c = 3.145;
            char d = 'd';

            string w = a.ToString();
            string x = b.ToString();
            string y = c.ToString();
            string z = d.ToString();

            bool e = bool.Parse(w);
            int f = int.Parse(x);
            double g = double.Parse(y);
            char h = char.Parse(z);
        }
        static void ConsoleIO()
        {
            Console.WriteLine("Hi, what is your first name?");
            var firstName = Console.ReadLine();

            Console.WriteLine("Thanks, also what is your last name?");
            var lastName = Console.ReadLine();

            Console.WriteLine($"Great, so you're name is {firstName} {lastName}.");
        }
        static void structs()
        {
            //Treat it like intializing a class
            Person Person1; //intialization
            Person1.name = "Daniel"; //declaring variables?
            Person1.eyeColor = "brown";
            Person1.age = 50;
        }
    }
}
