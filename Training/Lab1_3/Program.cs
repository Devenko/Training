using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factorial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please,  type numbers by step ");
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

        }
        #endregion

        #region calculator

        static void Calculator()
        {
            // Set Console.ForegroundColor  value
            Console.WriteLine(@"Select the arithmetic operation:
            1. Multiplication 
            2. Divide 
            3. Addition 
            4. Subtraction
            5. Exponentiation ");
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 

            char aggain = default(char);
            do
            {
                double a, b, total;
                int oper;

                Console.WriteLine("Select the arithmetic operation: ");
                while (!int.TryParse(Console.ReadLine(), out oper))
                {
                    Console.WriteLine("Input Error! Enter an integer");
                }
                Console.WriteLine("Introduce first number: ");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Input Error! Enter a floating point number");
                }
                Console.WriteLine("Introduce second number: ");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Input Error! Enter a floating point number");
                }
                if (oper == 1)
                {
                    total = a * b;
                    Console.WriteLine(a + " * " + b + " = " + total);
                }
                else if (oper == 2)
                {
                    total = a / b;
                    Console.WriteLine(a + " / " + b + " = " + total);
                }
                else if (oper == 3)
                {
                    total = a + b;
                    Console.WriteLine(a + " + " + b + " = " + total);
                }
                else if (oper == 4)
                {
                    total = a - b;
                    Console.WriteLine(a + " - " + b + " = " + total);
                }
                else if (oper == 5)
                {
                    total = Math.Pow(a, b);
                    Console.WriteLine(a + " ^ " + b + " = " + total);
                }
                else
                {
                    Console.WriteLine("Unknown operator");
                }

                Console.WriteLine("Want to continue working with the calculator? Yes - y No - n");
                while (!char.TryParse(Console.ReadLine(), out aggain))
                {
                    Console.WriteLine("Want to continue working with the calculator? Yes - y No - n");
                }
                if (aggain == 'n')
                   break;
            } while (aggain == 'y');
        }

        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            int factorial = 1;
            int x;
            Console.WriteLine("Enter an integer - X");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Input Error!  - X");
            }

            //Console.WriteLine("Enter an integer: ");
            //x = int.Parse(Console.ReadLine());
            for (int i = x; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial {x} = {factorial}");

            // Implement input of the number
            // Implement input the for circle to calculate factorial of the number
            // Output the result
        }
        #endregion
    }
}

