using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter if you want to Read Data(R) or Write Data(W)");
            string A = Console.ReadLine();
            {
                string R = "R";
                string W = "W";
                {
                    if (A == R)
                    {
                        Console.WriteLine("These are the details of the students : ");
                        string[,] std = new string[2,4];
                    {
                        std[0,0] = "1";
                        std[0, 1] = "Vishnu";
                        std[0, 2] = "Vardhan";
                        std[0, 3] = "26";
                        std[1, 0] = "2";
                        std[1, 1] = "Ajay";
                        std[1, 2] = "Kumar";
                        std[1, 3] = "26";

                    }
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Console.Write(std[i, j] + " ");
                                }
                            }
                        }
                        Console.WriteLine();
                        {
                            for (int i = 1; i < 2; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Console.Write(std[i, j] + " ");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter the details in order of ID, First Name, Last Name , Age : ");
                        string[,] student = new string[1,4];
                        for(int i =0;i<1;i++)
                        {
                            for (int j = 0; j < 4; j++)
                                    {
                                        student[i, j] = Console.ReadLine();
                                    }
                        }
                        for (int k = 0; k < 1; k++)
                        {
                            for (int l = 0; l < 4; l++)
                            {
                                Console.Write(student[k, l] + ",");
                            }
                        }
                    }

                }
                            }
            Console.ReadKey();
        }
    }
}
