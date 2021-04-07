using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please enter your first number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter your second number: ");
            string secondNumber = Console.ReadLine();

            int answer = int.Parse(firstNumber) * int.Parse(secondNumber);
            Console.WriteLine("Your answer is: " + answer);


            Console.ReadLine();
        }
    }
}
