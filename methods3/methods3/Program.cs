using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace methods_with_return_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            Program x = new Program();
            Program myObject = new Program();
            do
            {
                Console.WriteLine("Make a selection");
                Console.WriteLine("1: Fibonacci");
                Console.WriteLine("2: Mode");
                Console.WriteLine("3: Max of 5");
                Console.WriteLine("4: exit");
                Console.WriteLine("Please input a choice.");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Fib");
                        int ans = Convert.ToInt16(Console.ReadLine());
                        ans = myObject.Method1(ans);
                        Console.WriteLine(ans);
                        break;
                    case "2":
                        Console.WriteLine("MODE");
                        Console.WriteLine("5x ints");
                        int num1 = Convert.ToInt16(Console.ReadLine());
                        int num2 = Convert.ToInt16(Console.ReadLine());
                        int num3 = Convert.ToInt16(Console.ReadLine());
                        int num4 = Convert.ToInt16(Console.ReadLine());
                        int num5 = Convert.ToInt16(Console.ReadLine());
                        ans = myObject.Method2(num1, num2, num3, num4, num5);
                        Console.WriteLine(ans);
                        break;
                    case "3":
                        Console.WriteLine("MAX");
                        Console.WriteLine("5x ints");
                        int num6 = Convert.ToInt16(Console.ReadLine());
                        int num7 = Convert.ToInt16(Console.ReadLine());
                        int num8 = Convert.ToInt16(Console.ReadLine());
                        int num9 = Convert.ToInt16(Console.ReadLine());
                        int num0 = Convert.ToInt16(Console.ReadLine());
                        ans = myObject.Method3(num6, num7, num8, num9, num0);
                        Console.WriteLine(ans);
                        break;
                    case "4":
                        Console.WriteLine("i hate this");
                        break;
                }
            } while (choice != "4");
        }
        int Method1(int x)
        {
            int a = 0;
            int b = 1;
            for (int ans = 0; ans < x - 1; ans++)
            {
                int num = a;
                a = b;
                b = num + b;
            }
            return a;
        }
        int Method2(int num1, int num2, int num3, int num4, int num5)
        {
            int mode = num5;
            if (num1 == num2 || num1 == num3 || num1 == num4 || num1 == num5)
                mode = num1;
            if (num2 == num3 || num2 == num4 || num2 == num5 || num2 == num1)
                mode = num2;
            if (num3 == num1 || num3 == num2 || num3 == num4 || num3 == num5)
                mode = num3;
            if (num4 == num1 || num4 == num2 || num4 == num3 || num4 == num5)
                mode = num4;
            if (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4)
                mode = num5;
            return mode;
        }
        int Method3(int num6, int num7, int num8, int num9, int num0)
        {
            int max = num0;
            if (num6 > num7 && num6 > num8 && num6 > num9 && num6 > num0)
                max = num6;
            if (num7 > num8 && num7 > num9 && num7 > num0)
                max = num7;
            if (num8 > num9 && num8 > num0)
                max = num8;
            if (num9 > num0)
                max = num9;
            return max;
        }

    }
}



