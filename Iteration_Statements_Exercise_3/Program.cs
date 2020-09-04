using System;

namespace Iteration_Statements_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Print1000();
            //PrintBy3();
            //EqualOrNot(1, 4);
            //IsEvenOrOdd(2);
            //IsPositiveOrNegative(3);
            //CanVote();
            //InRange(11);
            //var collection = ArrayOfIndexers(7);
            //foreach (var number in collection)
            //{
            //    Console.WriteLine(number);
            //}
            //MultiplicationTable(111);
            //Console.WriteLine(ComputeSumOfArray(new int[] { 1, 2, 3, 4, 5, 6 }));
            //CubedNumber(5);


        }
        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintBy3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void EqualOrNot(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is not equal to y");
            }
        }

        static void IsEvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("this number is even");
            }
            else
            {
                Console.WriteLine("this number is odd");
            }
        }

        public static void IsPositiveOrNegative(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("this number is positive");
            }
            else if (x < 0)
            {
                Console.WriteLine("this number is negative");
            }
            else
            {
                Console.WriteLine("this number is zero");
            }
        }

        static void CanVote()
        {
            int num;
            bool conditional = true;

            while (conditional)
            {
                Console.WriteLine("Please enter your age");
                var userInput = Console.ReadLine();
                var age = int.TryParse(userInput, out num);
                if (age)
                {
                    if (num >= 18)
                    {
                        Console.WriteLine("You are old enough to vote");
                        conditional = false;
                    }
                    else
                    {
                        Console.WriteLine("you are not old enough to vote");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

        }

        static void InRange(int userInput)
        {
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("the number is in the range of 10 <--> -10");
            }
            else
            {
                Console.WriteLine("the number is not in the range of 10 <--> -10");
            }
        }

        static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

        static int[] ArrayOfIndexers(int number)
        {
            int[] arr = new int[number];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 100);
            }
            return arr;
        }

        static int ComputeSumOfArray(int[] arr)
        {
            //return arr.Sum();
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void CubedNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Number is: {i} and the cube of {i} is {i * i * i}");
            }
        }
    
    }
}
