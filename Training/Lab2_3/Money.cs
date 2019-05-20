using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    enum CurrencyTypes
    { UAH, USD, EUR }

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public decimal Amount { get; set; }
        public CurrencyTypes CurrencyType { get; set; }
        public static decimal[] Cource = new decimal[2];
        // 3) declare parameter constructor for properties initialization
        public Money()
        {
            Amount = 0m;
            CurrencyType = CurrencyTypes.UAH;
        }

        public Money(decimal Amount, CurrencyTypes CurrencyType)
        {
            this.Amount = Amount;
            this.CurrencyType = CurrencyType;
        }
        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money amnt1, Money amnt2)
        {
            Money amnt;
            if (amnt1.CurrencyType != amnt2.CurrencyType)
                Console.WriteLine("Different currencies");
            amnt = (Cource[0] == 0 | Cource[1] == 0)
                ? null
                : amnt1.CurrencyType == amnt2.CurrencyType
                    ? new Money(amnt2.Amount + amnt2.Amount, amnt1.CurrencyType)
                    : amnt1.CurrencyType == CurrencyTypes.UAH && amnt2.CurrencyType == CurrencyTypes.USD
                        ? new Money(amnt1.Amount + amnt2.Amount * Cource[0], amnt1.CurrencyType)
                        : amnt1.CurrencyType == CurrencyTypes.USD && amnt2.CurrencyType == CurrencyTypes.UAH
                            ? new Money(amnt1.Amount * Cource[0] + amnt2.Amount, amnt2.CurrencyType)
                            : amnt1.CurrencyType == CurrencyTypes.UAH && amnt2.CurrencyType == CurrencyTypes.EUR
                                ? new Money(amnt1.Amount + amnt2.Amount * Cource[1], amnt1.CurrencyType)
                                : amnt1.CurrencyType == CurrencyTypes.EUR && amnt2.CurrencyType == CurrencyTypes.UAH
                                    ? new Money(amnt1.Amount * Cource[1] + amnt2.Amount, amnt2.CurrencyType)
                                    : amnt1.CurrencyType == CurrencyTypes.USD && amnt2.CurrencyType == CurrencyTypes.EUR
                                        ? new Money(amnt1.Amount + amnt2.Amount * Cource[1] / Cource[0], amnt1.CurrencyType)
                                        : new Money(amnt1.Amount * Cource[1] / Cource[0] + amnt2.Amount, amnt2.CurrencyType);
            return amnt;
        }
        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money amnt)
        {
            return new Money(--amnt.Amount, amnt.CurrencyType);
        }

        public static Money operator ++(Money amnt)
        {
            return new Money(++amnt.Amount, amnt.CurrencyType);
        }
        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money amnt1, Money amnt2)
        {
            return new Money(amnt1.Amount * amnt2.Amount, amnt1.CurrencyType);
        }
        // 7) declare overloading of operator > and < to compare 2 objects of Money
        private static bool Compare(Money amnt1, Money amnt2)
        {
            bool comp;
            if (amnt1.CurrencyType != amnt2.CurrencyType) Console.WriteLine("Different currencies");
            if (Cource[0] == 0 | Cource[1] == 0)
            {
                Console.WriteLine("0 course");
                comp = false;
            }
            else
            {
                comp = amnt1.CurrencyType == amnt2.CurrencyType && amnt1.Amount > amnt2.Amount ? true
                : amnt1.CurrencyType == CurrencyTypes.UAH && amnt2.CurrencyType == CurrencyTypes.USD &&
                    amnt1.Amount > amnt2.Amount * Cource[0] ? true
                    : amnt1.CurrencyType == CurrencyTypes.USD && amnt2.CurrencyType == CurrencyTypes.UAH &&
                      amnt1.Amount * Cource[0] > amnt2.Amount ? true
                    : amnt1.CurrencyType == CurrencyTypes.UAH && amnt2.CurrencyType == CurrencyTypes.EUR &&
                      amnt1.Amount > amnt2.Amount * Cource[1] ? true
                    : amnt1.CurrencyType == CurrencyTypes.EUR && amnt2.CurrencyType == CurrencyTypes.UAH &&
                      amnt1.Amount * Cource[1] > amnt2.Amount ? true
                    : amnt1.CurrencyType == CurrencyTypes.USD && amnt2.CurrencyType == CurrencyTypes.EUR &&
                      amnt1.Amount > amnt2.Amount * Cource[1] / Cource[0] ? true
                    : amnt1.CurrencyType == CurrencyTypes.EUR && amnt2.CurrencyType == CurrencyTypes.USD &&
                      amnt1.Amount * Cource[1] / Cource[0] > amnt2.Amount ? true : false;
            }

            return comp;
        }

        public static bool operator >(Money amnt1, Money amnt2)
        {
            return Compare(amnt1, amnt2);
        }

        public static bool operator <(Money amnt1, Money amnt2)
        {
            return Compare(amnt1, amnt2);
        }
        // 8) declare overloading of operator true and false to check CurrencyType of object
        public static bool operator true(Money amnt)
        {
            return amnt.CurrencyType == CurrencyTypes.UAH;
        }

        public static bool operator false(Money amnt)
        {
            return amnt.CurrencyType != CurrencyTypes.UAH;
        }
        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        public static explicit operator double(Money amnt)
        {
            return (double) amnt.Amount;
        }

        public static explicit operator string(Money amnt)
        {
            return amnt.Amount.ToString() + " " + amnt.CurrencyType;
        }

        public static explicit operator Money(double amnt)
        {
            return new Money((decimal)amnt, CurrencyTypes.UAH);
        }

        public static explicit operator Money(string amnt)
        {
            decimal Amount = Convert.ToDecimal(amnt.Remove(amnt.Length - 4));
            var Curr = (CurrencyTypes) Enum.Parse(typeof(CurrencyTypes), amnt.Substring(amnt.Length - 3));
            return new Money(Amount, Curr);
        }
    }
}
