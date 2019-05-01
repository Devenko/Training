using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "*";
            //string space = " ";
            //string temp = "";
            int width = 0;
            int height = 0;
            Console.Write("Высота: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Ширина: ");
            width = int.Parse(Console.ReadLine());
            

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (j == 0 || j == height - 1) Console.Write("*");
                    else if (i == 0 || i == width - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            try
            {
                //Implement start position, width and height, symbol, message input

                //Create Box class instance

                //Use  Box.Draw() method

                Console.WriteLine("Press any key...");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }

        }
    }
}