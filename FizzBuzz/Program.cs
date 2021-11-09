using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            DoFizzBuzz();
        }
        static int GettingInfo()
        {
            Console.WriteLine("Give me last integer number, you want to check in FizzBuzz");
            string givenAnswer = Console.ReadLine();
            try
            {
                int givenNumber = int.Parse(givenAnswer);
                return givenNumber;
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not an integer", givenAnswer);
                Console.WriteLine("Try again!");
                GettingInfo();
                return 0;
            }
        }
        static void CheckDivisibility(int numberToCheck)
        {
            for (int i=1; i<=numberToCheck; i++)
            if (i % 15 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
            else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
            else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
            else
                {
                    Console.WriteLine(i);
                }
        }
        static void DoFizzBuzz()
        {
            int receivedNumber = GettingInfo();
            CheckDivisibility(receivedNumber);
        }
    }
}