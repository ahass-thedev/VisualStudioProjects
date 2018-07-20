using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace More_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int a, b;
            Console.WriteLine("Do you want to take the challenge?");
            x = Console.ReadLine();
            x = x.ToLower();
            if (x == "yes")
            {
                Console.WriteLine("Ok, what is the sum of 12 and 7");
                a = Convert.ToInt16(Console.ReadLine());
                if (a == 19)
                {
                    Console.WriteLine("You are not shit");
                }
                else
                {
                    Console.WriteLine("why are you shit");
                }
            }
            else if (x == "no")
            {
                Console.WriteLine("too bad soo sad");
            }//end else if 
            else
            {
                Console.WriteLine("english!");
            }//end else 

            Console.WriteLine("What are the first two prime numbers");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            if (a == 2 && b == 3)
            {
                Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("you are wrong");
            }

            string ans;
            int num1;
            Console.WriteLine("What is the square root of 16");
            num1 = Convert.ToInt16(Console.ReadLine());
            ans = (Console.ReadLine());
            if (ans == "four" || num1 == 4)
            {
                Console.WriteLine("Correct");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("incorrect");

            }

            int num2;
            Console.WriteLine("number?");
            num2 = Convert.ToInt16(Console.ReadLine());
            if (num2 > -4 && num2 < 6)
            {
                Console.WriteLine(" Your numer is between -4 and 6");
                Console.ReadLine();
            } 
            else
            {
                Console.WriteLine("Your number is not inbetween -4 and 6");
                Console.ReadLine();
            }
            String ans2;
            int c, d;
            Console.WriteLine("take challenege?");
            ans2 = (Console.ReadLine());
            if (ans2 == "yes")
            {
                Console.WriteLine("what is my age?");
                c = Convert.ToInt16(Console.ReadLine());
                if (c == 16)
                {
                    Console.WriteLine("what room is");
                    d = Convert.ToInt16(Console.ReadLine());
                    if (d == 272)
                    {
                        Console.WriteLine("Correct you win!");
                        Console.ReadLine();
                    }
                    else
                        Console.WriteLine("You lose");

                }
                else
                    Console.WriteLine("you lose");
            }
            else
                Console.WriteLine("You lose");
            Console.ReadLine();

        }
    }
}
