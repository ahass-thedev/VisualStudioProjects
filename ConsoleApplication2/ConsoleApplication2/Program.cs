using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method//I HATE MY LIFE
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            Program myObject = new Program();
            do
            {
                Console.WriteLine("Make a selection");
                Console.WriteLine("1: Letter");
                Console.WriteLine("2: Fact");
                Console.WriteLine("3: Sum");
                Console.WriteLine("4: exit");
                Console.WriteLine("Please input a choice.");
                choice = Console.ReadLine();

                      switch (choice)
                {
                        case "1":
                        Console.WriteLine("choose a letter");
                        char letter = (char)(Console.Read());
                        myObject.FindLetter(letter);
                        break;
                     case "2":
                        Console.WriteLine("1 and 10");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        myObject.factorial(numero);
                          break;
                          case "3":
                        Console.WriteLine("num");
                        int pickle = Convert.ToInt32(Console.ReadLine());
                        myObject.FactorSum(pickle);
                        break;
                          case "4":
                        Console.WriteLine("Im going to kill myself");
                        break;
                }
            } while (choice != "4");
        }
        void FindLetter(char letter)
        {
            string word = "suicide";
            if (word.Contains(letter))
            {
                Console.WriteLine("im close to killing my self");
            }
            else
            {
                Console.WriteLine("you dumb");
            }
        }
        void factorial(int Base)
        {
            if (Base >= 1 && Base <= 10)
            {
                int result = (factorial2(Base));
                Console.WriteLine("Your result is " + result);
            }
            else
            {
                Console.WriteLine("you screw up");
            }
        }
        int factorial2(int Base)
        {
            if (Base == 1)
            {
                return 1;
            }
            else
            {
                return Base * factorial2(Base - 1);
            }
        }
        void FactorSum(int UserNumber)
        {
            int total = 0;
            for (int i = 1; i <= UserNumber; i++)
            {
                if (UserNumber % i == 0)
                {
                    total = total + i;
                }
            }
            Console.WriteLine(total);
        }
    }
}

