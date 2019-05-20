using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money amount1 = new Money(1.0m, CurrencyTypes.USD);
            Money amount2 = new Money(1.0m, CurrencyTypes.EUR);
            Money amount3 = new Money(1.0m, CurrencyTypes.UAH);
            Money.Cource[0] = 25.0m;
            Money.Cource[1] = 27.0m;
            Console.WriteLine($"Amount1: {amount1} \r\nAmount2: {amount2}");
            Console.WriteLine($"Course USD: {Money.Cource[0]} \r\nCourse EUR: {Money.Cource[1]}");
            Money sum = new Money();
            // 11) do operations
            // add 2 objects of Money
            sum = amount1 + amount2;
            Console.WriteLine($"Sum: {sum.Amount} {sum.CurrencyType}");
            // add 1st object of Money and double
            double sum1 = (double) amount1 + 1.789;
            Console.WriteLine($"Sum: Amount1 + 1.789 = {sum1}");
            // decrease 2nd object of Money by 1 
            --amount2;
            Console.WriteLine($"Amount2 -- : {(string)amount2}");
            // increase 1st object of Money
            ++amount1;
            Console.WriteLine($"Amount1 ++ : {(string)amount1}");
            --amount1;

            Console.WriteLine($"\r\nAmount1: {(string)amount1} \r\n(Money)1: {(string)(Money)1}");
            amount1 = amount1 + (Money) 1;
            Console.WriteLine($"Amount1 ++ : {(string)amount1}");
            --amount1;
            Console.WriteLine($"\r\nAmount1: {(string)amount1} \r\nAmount2: {(string)amount2}");
            // compare 2 objects of Money
            bool comp = amount1 > amount2;
            Console.WriteLine($"amount1 > amount2 : {comp}");
            // compare 2nd object of Money and string
            if ((string) amount2 == "1 EUR")
            {
                Console.WriteLine("Amount2 = 1 EUR");
            }
            // check CurrencyType of every object
            if (amount1)
                Console.WriteLine("CurrencyType UAH");
            if (amount2)
                Console.WriteLine("CurrencyType UAH");
            if (amount3)
                Console.WriteLine("CurrencyType UAH");
            // convert 1st object of Money to string
            Console.WriteLine($"Amount1: {(string)amount1}");

            Console.ReadKey();
        }
    }
}
