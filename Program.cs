using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("==========================");
            string op = Op();
           // Console.WriteLine("\nYour valid operator is : " + op);
            

            Console.WriteLine("\nPlease enter your first number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter your second number: ");
            string secondNumber = Console.ReadLine();

            //int firstDigit = int.Parse(firstNumber);
            //int secondDigit = int.Parse(secondNumber);

            int answer = Answer(op, int.Parse(firstNumber), int.Parse(secondNumber));
            
            Console.WriteLine("\nYour answer is: " + answer);


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
            Console.WriteLine("\nPlease enter an operator: ");
            string val = Console.ReadLine();

            while (val != "*" && val != "/" && val != "+" && val != "-")
            {
                Console.WriteLine("\nPlease enter a valid operator: ");
                val = Console.ReadLine();
            }
            return val;
        }

        
    }
}
