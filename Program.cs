using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    internal class Program
    {

        // Задание 5.1
        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // Задание 5.2
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Задание 5.3
        static bool Factorial(int n, out int result)
        {
            result = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        // Задание 5.4
        static int RecursiveFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * RecursiveFactorial(n - 1);
        }

        // Домашнее задание 5.1
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int GCD(int a, int b, int c)
        {
            return GCD(a, GCD(b, c));
        }

        // Домашнее задание 5.2
        static int Fibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            // Задание 5.1
            Console.WriteLine("Задание 5.1");
            Console.WriteLine(Max(5, 10));
            Console.ReadKey();

            // Задание 5.2
            Console.WriteLine("Задание 5.2");
            int x = 5;
            int y = 10;
            Console.WriteLine($"До: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"После: x = {x}, y = {y}");
            Console.ReadKey();

            // Задание 5.3
            Console.WriteLine("Задание 5.3");
            if (Factorial(5, out int fact))
            {
                Console.WriteLine($"Факториал 5: {fact}");
            }
            Console.ReadKey();

            // Задание 5.4
            Console.WriteLine("Задание 5.4");
            Console.WriteLine(RecursiveFactorial(5));
            Console.ReadKey();

            // Домашнее задание 5.1
            Console.WriteLine("Домашнее задание 5.1");
            Console.WriteLine(GCD(24, 18));
            Console.WriteLine(GCD(24, 18, 36));
            Console.ReadKey();

            // Домашнее задание 5.2
            Console.WriteLine(" Домашнее задание 5.2");
            Console.WriteLine(Fibonacci(6));
            Console.ReadKey();
        }
    }
}
