using System;

namespace Lab1_4
{
    class Program
    {
        // 1) declare enum ComputerType

        enum ComputerType
        {
            Desktop,
            Laptop,
            Server
        }

        // 2) declare struct Computer
        struct Computer
        {
            public byte cpu;
            public float frequency;
            public int memory;
            public int hdd;

            //public Computer(byte cpu, float frequency, int memory, int hdd)
            //{
            //    this.cpu = cpu;
            //    this.frequency = frequency;
            //    this.memory = memory;
            //    this.hdd = hdd;
            //}
            //public void Info()
            //{
            //    Console.WriteLine($"CPU {cpu} core, {frequency} HGz; memory {memory} Gb;HDD {hdd}Gb.");
            //}

        }

        static void Main(string[] args)
        {
            //Computer tmpComputer;

            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[,][] computers = new Computer[4, 3][];

            //int[,] depart = new int[,] {{2,2,1},
            //                            {0,3,0},
            //                            {3,2,0},
            //                            {1,1,2}};

            // 4) set the size of every array in jagged array (number of computers)
            computers[0, 0] = new Computer[2];
            computers[0, 1] = new Computer[2];
            computers[0, 2] = new Computer[1];
            computers[1, 0] = new Computer[0];
            computers[1, 1] = new Computer[3];
            computers[1, 2] = new Computer[0];
            computers[2, 0] = new Computer[3];
            computers[2, 1] = new Computer[2];
            computers[2, 2] = new Computer[0];
            computers[3, 0] = new Computer[1];
            computers[3, 1] = new Computer[1];
            computers[3, 2] = new Computer[2];

            // 5) initialize array
            // Note: use loops and if-else statements
            for (int i = 0; i < computers.GetLength(0); i++)
            {
                for (int j = 0; j < computers.GetLength(1); j++)
                {
                    for (int k = 0; k < computers[i, j].Length; k++)
                    {
                        if (j == (int)ComputerType.Desktop)
                        {
                            computers[i, j][k].cpu = (byte)(4 + 2 * k);
                            computers[i, j][k].frequency = 2.5f;
                            computers[i, j][k].memory = 6;
                            computers[i, j][k].hdd = 500;
                        }

                        if (j == (int)ComputerType.Laptop)
                        {
                            computers[i, j][k].cpu = 2;
                            computers[i, j][k].frequency = 1.7f;
                            computers[i, j][k].memory = 4;
                            computers[i, j][k].hdd = 250;
                        }

                        if (j == (int)ComputerType.Server)
                        {
                            computers[i, j][k].cpu = (byte)(8 + 2 * k);
                            computers[i, j][k].frequency = 3.0f;
                            computers[i, j][k].memory = 16;
                            computers[i, j][k].hdd = 2048;
                        }
                    }
                }
            }

            // Desktop
            //Computer c1;

            //c1.cpu = 4;
            //c1.frequency = 2.5;
            //c1.memory = 6;
            //c1.hdd = 500;
            //Console.Write("Desktop: ");
            //c1.Info();

            //// Laptop
            //Computer c2;
            //c2.cpu = 2;
            //c2.frequency = 1.7;
            //c2.memory = 4;
            //c2.hdd = 250;
            //Console.Write("Laptop: ");
            //c2.Info();

            //// Server
            //Computer c3;
            //c3.cpu = 8;
            //c3.frequency = 3;
            //c3.memory = 16;
            //c3.hdd = 2000;
            //Console.Write("Server: ");
            //c3.Info();

            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            bool EveryType = true;
            for (int l = 0; l < 2; l++)
            {
                int CompCount = 0;
                foreach (ComputerType iCompType in Enum.GetValues(typeof(ComputerType)))
                {
                    if (EveryType)
                    {
                        CompCount = 0;
                    }
                    for (int i = 0; i < computers.GetLength(0); i++)
                    {
                        for (int k = 0; k < computers[i,(int)iCompType].Length; k++)
                        {
                            CompCount++;
                        }
                    }

                    if (EveryType)
                    {
                        Console.WriteLine(iCompType + ": computer count = " + CompCount);
                    }
                }

                if (!EveryType)
                {
                    Console.WriteLine("Computer count = " + CompCount);
                }

                EveryType = false;
            }

            //var comArray = new Computer[3];

            //comArray[0] = c1;
            //comArray[1] = c2;
            //comArray[2] = c3;
            //foreach (Computer VARIABLE in comArray)
            //{
            //    //if (VARIABLE.hdd > 1000)
            //    //{
            //    VARIABLE.Info();
            //    //}
            //}
            //Console.WriteLine(new string('*', 30));
            //int totalDesktop = 0, totalLaptop = 0, totalServer = 0, total = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    totalDesktop += depart[i, 0];
            //    totalLaptop += depart[i, 1];
            //    totalServer += depart[i, 2];
            //}
            //total = totalDesktop + totalLaptop + totalServer;

            //Console.WriteLine("Desktop: " + totalDesktop);
            //Console.WriteLine("Laptop:  " + totalLaptop);
            //Console.WriteLine("Server:  " + totalServer);
            //Console.WriteLine("Total: " + total);


            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements


            //Console.WriteLine(new string('~', 30));
            //var maxHDD = new Computer();
            //int indexMaxHDD = 0;
            //for (int i = 0; i < comArray.Length; i++)
            //{
            //    if (comArray[i].hdd > maxHDD.hdd)
            //    {
            //        maxHDD = comArray[i];
            //        indexMaxHDD = Array.IndexOf(comArray, comArray[i]);
            //    }
            //}
            //Console.Write($"Index with the Max HDD: {indexMaxHDD}\n");
            //maxHDD.Info();

            //Console.WriteLine(new string('~', 30));


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            if (computers.Length != 0)
            {
                int[,] extrIndexes = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                int maxHDD = computers[0, 0][0].hdd;
                float minCPU = computers[0, 0][0].cpu * computers[0, 0][0].frequency;
                int minMemory = computers[0, 0][0].memory;

                float[] estimate = new float[3];
                for (int iCase = 0; iCase < 3; iCase++)
                {
                    switch (iCase)
                    {
                        case 0:
                            estimate[iCase] = maxHDD;
                            Console.WriteLine("\r\nMin HDD: ");
                            break;
                        case 1:
                            estimate[iCase] = minCPU;
                            Console.WriteLine("\r\nMin CPU: ");
                            break;
                        case 2:
                            estimate[iCase] = minMemory;
                            Console.WriteLine("\r\nMin memory: ");
                            break;
                    }

                    foreach (ComputerType iCompType in Enum.GetValues(typeof(ComputerType)))
                    {
                        for (int i = 0; i < computers.GetLength(0); i++)
                        {
                            for (int k = 0; k < computers[i, (int)iCompType].Length; k++)
                            {
                                switch (iCase)
                                {
                                    case 0:
                                        if (estimate[iCase] < computers[i, (int)iCompType][k].hdd)
                                        {
                                            estimate[iCase] = computers[i, (int)iCompType][k].hdd;
                                            indexSetup(iCase, i, (int)iCompType, k, ref extrIndexes);
                                        }

                                        break;
                                    case 1:
                                        if (estimate[iCase] > computers[i, (int)iCompType][k].cpu *
                                            computers[i, (int)iCompType][k].frequency)
                                        {
                                            estimate[iCase] =
                                                computers[i, (int)iCompType][k].cpu *
                                                computers[i, (int)iCompType][k].frequency;
                                            indexSetup(iCase, i, (int)iCompType, k, ref extrIndexes);
                                        }

                                        break;
                                    case 2:
                                        if (estimate[iCase] > computers[i, (int)iCompType][k].memory)
                                        {
                                            estimate[iCase] = computers[i, (int)iCompType][k].memory;
                                            indexSetup(iCase, i, (int)iCompType, k, ref extrIndexes);
                                        }

                                        break;
                                }
                            }
                        }

                    }

                    Console.Write(estimate[iCase] + ". Computer indexes: ");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(extrIndexes[iCase, i] + " ");
                        ;
                    }

                    Console.WriteLine("\r\n");
                }

                for (int i = 0; i < computers.GetLength(0); i++)
                {
                    for (int k = 0; k < computers[i, (int)ComputerType.Desktop].Length; k++)
                    {
                        computers[i, (int)ComputerType.Desktop][k].memory = 8;
                        Console.WriteLine($"Desktop {i} {(int)ComputerType.Desktop} {k}");
                    }
                }

            }
            //var lowestCom = comArray[0];
            //int indexLowestCom = 0;
            //for (int i = 0; i < comArray.Length; i++)
            //{
            //    if ((comArray[i].cpu < lowestCom.cpu) && (comArray[i].memory < lowestCom.memory))
            //    {
            //        lowestCom = comArray[i];
            //        indexLowestCom = Array.IndexOf(comArray, comArray[i]);
            //    }
            //}
            //Console.Write($"Index with the lowest productivity (CPU and memory): {indexLowestCom}\n");
            //lowestCom.Info();

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements



            //    for (int i = 0; i < comArray.Length; i++)
            //    {
            //        if (comArray[i].memory == 6)
            //        {
            //            comArray[i].memory = 8;
            //        }
            //    }
            //    Console.WriteLine(new string('%', 30));
            //    foreach (Computer VARIABLE in comArray)
            //    {
            //        //if (VARIABLE.hdd > 1000)
            //        //{
            //        VARIABLE.Info();
            //        //}
            //    }
            //    Console.WriteLine(new string('%', 30));
            //    Console.ReadLine();
            //}
            Console.ReadKey();
        }

        public static void indexSetup(int iCase, int i, int j, int k, ref int[,] extrIndexes)
        {
            extrIndexes[iCase, 0] = i;
            extrIndexes[iCase, 1] = j;
            extrIndexes[iCase, 2] = k;
        }
    }
}

