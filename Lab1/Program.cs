using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 0;
            double a = 0;
            double b = 0;
            double n = 0;
            double m = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter n:");
                    n = Convert.ToDouble(Console.ReadLine());

                    if(n <= a)
                    {
                        Console.WriteLine("Invalid data");
                        continue;
                    }

                    Console.WriteLine("Enter m:");
                    m = Convert.ToDouble(Console.ReadLine());
                    if (m <= b)
                    {
                        Console.WriteLine("Invalid data");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter digit!");
                }

            }
            try
            {
                for (double i = a; i < n; i++)
                {
                    for (double j = b; j < m; j++)
                    {
                        S += (i / j) / (i+2);
                    }
                }
                Console.WriteLine(S);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            Console.ReadKey();
        }
    }
}
