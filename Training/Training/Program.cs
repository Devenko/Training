using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_4
{
    class Program
    {
        // 1) declare enum ComputerType


        // 2) declare struct Computer
        struct Computer
        {

            enum ComputerType { Desktop = 1, Laptop, Server }

            public double cpu;
            public double frequency;
            public double memory;
            public double hdd;

            //public Computer(double cpu, double frequency, double memory, double hdd)
            //{
            //   
            //    this.cpu = cpu;
            //    this.frequency = frequency;
            //    this.memory = memory;
            //    this.hdd = hdd;
            //}
            public void Info()
            {

                Console.WriteLine($"CPU {cpu} core, {frequency} HGz; memory {memory} Gb;HDD {hdd}Gb.");
            }
        }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            int[,] depart = new int[,] {{2,2,1},
                                        {0,3,0},
                                        {3,2,0},
                                        {1,1,2}};

            // 4) set the size of every array in jagged array (number of computers)


            // 5) initialize array
            // Note: use loops and if-else statements

            // Desktop
            Computer c1;

            c1.cpu = 4;
            c1.frequency = 2.5;
            c1.memory = 6;
            c1.hdd = 500;
            Console.Write("Desktop: ");
            c1.Info();

            // Laptop
            Computer c2;
            c2.cpu = 2;
            c2.frequency = 1.7;
            c2.memory = 4;
            c2.hdd = 250;
            Console.Write("Laptop: ");
            c2.Info();

            // Server
            Computer c3;
            c3.cpu = 8;
            c3.frequency = 3;
            c3.memory = 16;
            c3.hdd = 2000;
            Console.Write("Server: ");
            c3.Info();

            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)


            int totalDesktop = 0, totalLaptop = 0, totalServer = 0, total = 0;
            for (int i = 0; i < 4; i++)
            {
                totalDesktop += depart[i, 0];
                totalLaptop += depart[i, 1];
                totalServer += depart[i, 2];

                for (int j = 0; j < 3; j++)
                {
                    total += depart[i, j];

                   // if (depart[i, j] == depart[i, 0])
                    //   totalDesktop += depart[i, 0];
                }
            }
            Console.WriteLine("Desktop: " + totalDesktop);
            Console.WriteLine("Laptop:  " + totalLaptop);
            Console.WriteLine("Server:  " + totalServer);
            Console.WriteLine("Total: " + total);

            Console.ReadLine();
            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions


            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

        }

    }
}
