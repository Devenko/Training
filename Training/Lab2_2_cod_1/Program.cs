using System;


namespace Hello_fact_advstud
{
    class Program
    {
        static ulong Factorial(uint n)
        {
            return n == 0 ? 1 : Factorial(n - 1) * n;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Factorial {0} = {1}",n ,Factorial(n));

            Console.ReadLine();
            //Define parameters to calculate the factorial of
            //Call fact() method to calculate
        }

        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator
    }

}