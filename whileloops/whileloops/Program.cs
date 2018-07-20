using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Do_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            int n;
            do
            {
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("1: Use a while loop");
                Console.WriteLine("2: See a message");
                Console.WriteLine("3: Exit");
                Console.WriteLine("4: chose a number to countdown from");
                y = Console.ReadLine();
                if (y == "1")
                {
                    Console.WriteLine("Enter a number");
                    int x = Convert.ToInt32(Console.ReadLine());
                    while (x < 10)
                    {
                        Console.WriteLine(x);
                        x++;
                    }
                }

                else if (y == "2")
                {
                    do
                    {
                        Console.WriteLine("\nWhat is the square root of 841\n");

                        n = Convert.ToInt32(Console.ReadLine());

                    } while (n != 29 );


                }
                else if (y == "3")
                {
                    Console.WriteLine("\nWHY YOU LEAVE!\n");
                }
                else if (y == "4")
                {
                    Console.WriteLine(" input a number");
                    int x = Convert.ToInt16(Console.ReadLine());
                    while (x > 0)
                    {
                        Console.WriteLine(x);
                        x--;
                    }
                }
                else
                {
                    Console.WriteLine("\nCAN YOU READ, NOT AN OPTIONS\n");
                }           
            } while (y != "3");

        }
    }
}