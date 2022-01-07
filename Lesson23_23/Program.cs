using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson23_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            FactorialAsync(n);

            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            int factorial = 1;
            for (int i = 2; i < n; i++)
            {
                factorial = factorial * i;
                Thread.Sleep(100);
            }
            Console.WriteLine(factorial);
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
