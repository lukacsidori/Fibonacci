using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());            
            Console.WriteLine("----------------------------------");
            
            Fibonacci(szam);
            
            Console.ReadKey();

        }

        public static void Fibonacci(int n)
        {
            int result = 0;
            int previous = 1;

            Console.WriteLine("A Fibonacci elemek a következők: ");
            Console.WriteLine(result);
                
            for (int i = 0; i < n-1; i++)
            {
                int temp = result;
                result = previous;
                Console.WriteLine(result);
                previous = temp + previous;
            }
            
        }


    }
}
