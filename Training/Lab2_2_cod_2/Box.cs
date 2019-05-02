using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2_cod_2
{
    class Box
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        private int width;
        public int Widht
        {
            get { return width; }
            set { width = value; }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private string symbol;
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        
        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box
        public void Draw(int height, int width, int x, int y, string symbol)
        {
            for (int j = 0; j < 15; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (j == 0 || j == 14)
                    {
                        Console.SetCursorPosition(x + 2, y + 2);
                        Console.Write("*");
                    }
                    else if (i == 0 || i == 4)
                    {
                        Console.SetCursorPosition(x + 2, y + 2);
                        Console.Write("*");
                    }
                    else
                    {
                        Console.SetCursorPosition(x + 2, y + 2);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("Ширина: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Высота: ");
            width = int.Parse(Console.ReadLine());
            Console.Write("Отступ справа: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Отступ сверху: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Введите символ, каким рисовать прямоугольник: ");
            symbol = Convert.ToString(Console.ReadLine());
        }

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message

        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary
        private void Draw()
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (j == 0 || j == height - 1)
                    {
                        Console.SetCursorPosition(x + j, y + i);
                        Console.Write(symbol);
                    }
                    else if (i == 0 || i == width - 1)
                    {
                        Console.SetCursorPosition(x + j, y + i);
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.SetCursorPosition(x + j, y + i);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
