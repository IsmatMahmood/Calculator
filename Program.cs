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
            string operation = GetOperator(); 
            int iterations = GetIterations(operation);
            int[] numbers = GetNumbers(operation, iterations);

            int answer = Answer(operation, numbers);

            Console.WriteLine("\nYour answer is: " + answer);
        }

        private static int GetIterations(string operation)
        {
            Console.WriteLine("How many numbers would you like to {0}? : ", operation);
            string iterations = Console.ReadLine();
            return int.Parse(iterations);
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("==========================");
        }

        private static int[] GetNumbers(string operation, int iterations) 
        {
            
            int[] numbers = new int[iterations];
            
            for (int i = 0;i<iterations;i++)
            {
                Console.WriteLine("Please enter number {0}: ", i+1);
                string digit = Console.ReadLine();
                numbers[i] = int.Parse(digit);
            }
            return numbers;
        }

        private static int Answer(string operation, int[] numbers)
        {
            int answer = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (operation == "+")
                {
                    answer = answer + numbers[i];
                }
                else if (operation == "-")
                {
                    answer = answer - numbers[i];
                }
                else if (operation == "/")
                {
                    answer = answer /numbers[i];
                }
                else if (operation == "*")
                {
                    answer = answer * numbers[i];
                }
            }
            
            return answer;
        }

        private static string GetOperator()
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
