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

    public enum ProductCodes
    {
        Milk = 98348943,
        Juice = 34034045,
        Tea = 12345678
    }

    public enum Mood
    {
        Undefined,
        Happy,
        Sad,
        Hungry
    }

    class Program
    {
        static void Main(string[] args)
        {
            //switchStatements();
            multiDimensionalArrays();
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
        static void enums()
        {
            ProductCodes test = ProductCodes.Milk;
            Console.WriteLine((int)test); //Outputs the productcode for Milk

            int test2 = 12345678;
            Console.WriteLine((ProductCodes)test2); //Outputs Tea

            Console.WriteLine(test.ToString()); //Outputs "Milk" as a string

            //Take a stirng and convert it into an enum (parsing)
            //string test3 = "Tea";
            //Check whether or not this is going to parse before you parse the data

            //ProductCodes getParse;
            // bool checkParse = Enum.TryParse(test3, out getParse);

            //This no longer works for some reason, but it did in his video
            //says there is no TryParse or Parse method in enum class.
            //Console.WriteLine(getParse);
        }
        static void switchStatements()
        {
            var mood = Mood.Sad;

            switch (mood)
            {
                case Mood.Happy:
                    Console.WriteLine("I'm glad you're happy.");
                    break;

                case Mood.Sad:
                case Mood.Hungry:
                    Console.WriteLine("Eat Something!");
                    break;

                default:
                    Console.WriteLine("The mood is invalid");
                    break;
            }
        }
        static void multiDimensionalArrays()
        {
            //this intiializes a 2d array of 3 integer values in first column
            //and three in the second column. 3x3 Matrix
            var my2dArray = new int[3, 3];
            my2dArray[0, 0] = 1;
            my2dArray[0, 1] = 2;

            //This initializes a 3d array of 5x5x5 of integers
            var my3Darray = new int[5, 5, 5];

            //How to access the value in these arrays:
            int numAt000 = my2dArray[0, 0];
            Console.WriteLine(numAt000);

            //Remmeber arrays can hold any type, including other arrays, enums
            //... and structs/objects
        }
    }
}
