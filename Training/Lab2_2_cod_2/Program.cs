using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Lab2_2_cod_2;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int width = 0;
            //int height = 0;
            //int x = 0, y = 0;
            //string symbol;


            //Console.Write("Ширина: ");
            //height = int.Parse(Console.ReadLine());
            //Console.Write("Высота: ");
            //width = int.Parse(Console.ReadLine());
            //Console.Write("Отступ справа: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Отступ сверху: ");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("Введите символ, каким рисовать прямоугольник: ");
            //symbol = Convert.ToString(Console.ReadLine());
            //// Console.SetWindowSize(130, 70); // установка ширины и высоты консоли

            //Console.Clear();
            //// Console.SetCursorPosition(2, 2);

            //for (int j = 0; j < height; j++)
            //{
            //    for (int i = 0; i < width; i++)
            //    {
            //        if (j == 0 || j == height - 1)
            //        {
            //            Console.SetCursorPosition(x+j, y+i);
            //            Console.Write(symbol);
            //        }
            //        else if (i == 0 || i == width - 1)
            //        {
            //            Console.SetCursorPosition(x+j,y+i);
            //            Console.Write(symbol);
            //        }
            //        else
            //        {
            //            Console.SetCursorPosition(x+j,y+i);
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            int wid = Console.WindowWidth; //ширина консоли
            int hei = Console.WindowHeight; //высота консоли
            Console.WriteLine($"высота{hei}  ширина{wid}");
            try
            {
                //Implement start position, width and height, symbol, message input
                Box box = new Box();
                box.Draw(5,15,5,5,"+");
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