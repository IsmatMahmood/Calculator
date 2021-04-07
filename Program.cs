using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            PerformOneCalculation();
                    
            Console.ReadLine();
        }

        private static void PerformOneCalculation()
        {
            string op = Op(); // gets operator using method below
            int[] numbers = GetNumbers(op);

            int answer = Answer(op, numbers);

            Console.WriteLine("\nYour answer is: " + answer);
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("==========================");
        }

        private static int[] GetNumbers(string op) 
        {
            Console.WriteLine("How many numbers would you like to {0}? : ", op);
            string iterations = Console.ReadLine();
            int Iterations = int.Parse(iterations);
            int[] numbers = new int[Iterations];
            
            for (int i = 0;i<Iterations;i++)
            {
                Console.WriteLine("Please enter number {0}: ", i+1);
                string digit = Console.ReadLine();
                numbers[i] = int.Parse(digit);
            }
            return numbers;
        }

        private static int Answer(string op, int[] numbers)
        {
            int answer = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (op == "+")
                {
                    answer = answer + numbers[i];
                }
                else if (op == "-")
                {
                    answer = answer - numbers[i];
                }
                else if (op == "/")
                {
                    answer = answer /numbers[i];
                }
                else if (op == "*")
                {
                    answer = answer * numbers[i];
                }
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
