using System;
using System.Threading;

namespace Lab1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("music");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region ToFromBinary
        static void My_Binary()
        {
            //Implement positive integer variable input
            int q;
            Console.Write("Enter the number: ");
            q = Int32.Parse(Console.ReadLine());

            //Present it like binary string
            //   For example, 4 as 100
            String number = Convert.ToString(q, 2);
            Console.WriteLine($"Number = {q} in binary = {number}");

            //Use modulus operator to obtain the remainder  (n % 2) 
            //and divide variable by 2 in the loop
            Console.WriteLine("The remainder of dividing " + q + " by 2: " + q % 2);

            //Use the ToCharArray() method to transform string to chararray
            //and Array.Reverse() method
            Array numberArray = number.ToCharArray();


            Console.WriteLine("\n" + new string('-', 100));
            Array.Reverse(numberArray);
            foreach (var VARIABLE in numberArray)
            {
                Console.Write(VARIABLE);
            }
            Console.WriteLine($"\nf({q}) = {q} ({number})");
        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            //Declare int and string variables for decimal and binary presentations
            int x, y;
            string xStr = "", yStr = "";
            //Implement two positive integer variables input
            Console.Write("Enter the first number: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            y = Int32.Parse(Console.ReadLine());

            if (x < 0)
            {
                x *= -1;
            }

            if (y < 0)
            {
                y *= -1;
            }
            Console.WriteLine($"X = {x}; Y = {y}.");
            //To present each of them in the form of unary string use for loop
            //xStr = Convert.ToString(x, 2);
            //yStr = Convert.ToString(y, 2);
            //Use concatenation of these two strings 
            //Note it is necessary to use some symbol ( for example “#”) to separate
            char sep = '#';

            for (int i = 0; i < x; i++)
            {
                xStr += "1";
            }
            for (int i = 0; i < y; i++)
            {
                yStr += "1";
            }
            string result = xStr + sep + yStr;
            
            foreach (var VARIABLE in result)
            {
                Console.Write(VARIABLE);
            }
            Console.WriteLine("\n" + new string('+', 30));

            while ((result[result.Length - 1] != '#') && (result[0] != '#'))
            {
                result = result.Remove(result.Length - 1, 1);
                result = result.Remove(0, 1);
                Console.WriteLine(result);
            }
            
            foreach (var VARIABLE in result)
            {
                Console.Write(VARIABLE);
            }
            Console.WriteLine("\n" + new string('-', 30));

            foreach (var VARIABLE in result)
            {
                Console.Write(VARIABLE);
            }

            //Check the numbers on the equality 0
            //Realize the  algorithm for replacing '1#1' to '#' by using the for loop 
            //Delete the '#' from algorithm result
            int index = 0;
            int w = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == sep)
                {
                    index = result.IndexOf(sep);
                    Console.WriteLine($"\nIndex = {index}");
                    result = result.Remove(index, 1);
                    Console.WriteLine(result);
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                ++w;
            }
            Console.WriteLine($"Result = {w}");
            //Output the result 
        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {
            //Create string variable for 'sos'      
            string sos = "sos";
            //Use string array for Morse code
            string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};

            Console.WriteLine("\n" + new string('*', 30));
            //Use ToCharArray() method for string to copy characters to Unicode character array
            //Use foreach loop for character array in which
            string[,] dictUnic;
            foreach (var w in Dictionary_arr)
            {

                //w.ToCharArray() = new string[,];
            }

            //Implement Console.Beep(1000, 250) for '.'
            // and Console.Beep(1000, 750) for '-'

            //Use Thread.Sleep(50) to separate sounds
            //                  
        }

        #endregion
    }
}
