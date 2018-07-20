//Ahmed Hassanein
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            Console.WriteLine("Hello " + word);

            Console.WriteLine("Enter a number");
            double numberone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number");
            double numbertwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number");
            double numberthree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number");
            double numberfour = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number");
            double numberfive = Convert.ToDouble(Console.ReadLine());
            double semfin = numberone + numbertwo + numberthree + numberfour + numberfive;
            double final = semfin / 5;
            Console.WriteLine("Your mean is: " + final);
            Console.WriteLine("Guess my magic number");

            double magic = Convert.ToDouble(Console.ReadLine());


            while (magic != 17)
            {
                if (magic == 17)
                {
                    Console.WriteLine("You guessed right");
                }
                if (magic >= 17)
                {
                    Console.WriteLine("Guess Lower");
                }
                if (magic <= 17)
                {
                    Console.WriteLine("Guess Higher");
                }
                break;
            }
   
            Console.ReadLine();
        }
    }
}
