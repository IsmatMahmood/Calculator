using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            string op = Op();
            Console.WriteLine("Your valid operator is : " + op);
            

            Console.WriteLine("Please enter your first number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter your second number: ");
            string secondNumber = Console.ReadLine();

            int firstDigit = int.Parse(firstNumber);
            int secondDigit = int.Parse(secondNumber);

            int answer = Answer(op, firstDigit,secondDigit);
            
            Console.WriteLine("Your answer is: " + answer);


            Console.ReadLine();
        }

        private static int Answer(string op, int firstDigit, int secondDigit)
        {
            int answer = 0;
            if (op == "+")
            {
                answer = firstDigit + secondDigit;
            }
            else if (op == "-")
            {
                answer = firstDigit - secondDigit;
            }
            else if (op == "/")
            {
                answer = firstDigit / secondDigit;
            }
            else if (op == "*")
            {
                answer = firstDigit * secondDigit;
            }
            
            return answer;
        }

        private static string Op()
        {
            Console.WriteLine("Please enter an operator");
            string val = Console.ReadLine();

            while (val != "*" && val != "/" && val != "+" && val != "-")
            {
                Console.WriteLine("Please enter a valid operator");
                val = Console.ReadLine();
            }
            return val;
        }

        
    }
}
