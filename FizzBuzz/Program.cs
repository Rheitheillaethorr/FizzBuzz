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
                return 0; //Program.Gettinginfo()': not all code path return a value --> easy xD
            }
        }
        static void DoFizzBuzz()
        {
            int x = GettingInfo();
            Console.WriteLine(x);
        }
    }
}