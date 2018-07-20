using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace into_to_methods
{

    class Program
    {

        static void Main(string[] args)
        {

            Program x = new Program();

            string choice = "";

            do
            {

                Console.WriteLine("Choose one of the following options:");

                Console.WriteLine("1: Use method1 \n2: Use method2 \n3: Use method3\n4:" +

                "Use method4");

                Console.WriteLine("5: Exit");

                choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":

                        x.method1();

                        break;

                    case "2":

                        x.method2();

                        Console.WriteLine("Input 2 numbers");

                        break;

                    case "3":

                        x.method3();

                        Console.WriteLine("boom");

                        break;

                    case "4":
                        x.method4();

                        Console.WriteLine("Factors");

                        break;

                    case "5":

                        Console.WriteLine("Good Bye");

                        break;

                }//end swtich 

            } while (choice != "5");

        }

        void method1()
        {

            Console.WriteLine("What is your name?");

            string a = Console.ReadLine();

            Console.WriteLine("Hello" + a);

        }//end myMethod 

        void method2()
        {
            Console.WriteLine("Input two numbers");

            int n = Convert.ToInt16(Console.ReadLine());

            int y = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(n + y);

            Console.WriteLine(n - y);

            Console.WriteLine(n / y);

            Console.WriteLine(n * y);

        }

        void method3()
        {
            Console.WriteLine("Input a number");

            int b = Convert.ToInt16(Console.ReadLine());

            for (int x = b; x > 0; x--)

                Console.WriteLine("Countdown" + x);
        }
        void method4()
        {
            Console.WriteLine("Input two numbers");

            int n2 = Convert.ToInt16(Console.ReadLine());

            int y2 = Convert.ToInt16(Console.ReadLine());

            if (n2 % y2 == 0)
            {
                Console.WriteLine("They are Factors");
                Console.WriteLine(n2 / y2);

            }
            if (n2 % y2 != 0)
            {
                Console.WriteLine("They are not Factors");
                Console.WriteLine(n2 / y2);

            }
        }
    }
}


