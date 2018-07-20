using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace For_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER");
            Console.ReadLine();
            for (int x = 1; x < 16; x++)
            {
                Console.WriteLine("The loop has run " + x + " times.");
            }//end for 
            Console.WriteLine("Press enter to start the countdown loop");
            Console.ReadLine();
            for (int y = 10; y >= 0; y--)
            {
                Console.ReadLine(); Console.WriteLine("Time to explosion: " + y);
                if (y == 0)
                {
                    Console.WriteLine("Boom");
                }//End if 
            }//end for 
            Console.WriteLine("HELLo LOOP");
            Console.ReadLine();
            for (int x = 1; x < 6; x++)
            {
                Console.WriteLine("GOODBYE" + x);
            }//end for 

            Console.ReadLine();
            {

                int n;

                for (int x = 0; x < 3; x++)
                {
                    Console.WriteLine("What is the square root of 841");
                    n = Convert.ToInt16(Console.ReadLine());
                    if (n == 29)
                    {
                        Console.WriteLine("You are not shit");
                        x = 3;

                    }
                    else
                    {
                        Console.WriteLine("You are shit");

                    }
                    Console.ReadLine();
                }



            }
        }
    }
}