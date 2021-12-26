using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Integral
{
    internal class Program
    {
        public const double start = -10; 
        public const double end = 10;
        public const int n = 2; //количество отрезков
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine($"---------INTEGRAL-------------");
            Console.WriteLine("Enter function with param х :");
                var str = Console.ReadLine();
                if (String.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Enter is null or empty");
                    return;
                }

                Console.WriteLine("Enter step");

            if (!Int32.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine($"-------------------------");

            try
                {
                    var x = Expression.Parameter(typeof(double), "x");
                    var expression = ParseFormula.DynamicExpression.ParseLambda(
                        new ParameterExpression[] { x },
                        typeof(double),
                        str);

                    var func = (Func<double, double>)expression.Compile();


                    var sw = new Stopwatch();
                
                
                int accuracy = 10;
                {
                    var calculate = new СalculateIntegral();
                    sw.Start();
                    var y = СalculateIntegral.Calculate(func, start, end, n, accuracy);
                    if (y < 0)
                    {
                        y = Math.Abs(y);
                    }
                    sw.Stop();
                    var ts = sw.Elapsed.TotalMilliseconds;
                    Console.WriteLine($"Result [-10;10] f({str}) = { y } ");
                    Console.WriteLine($"Time:   {ts} milliseconds");
                    Console.WriteLine($"-------------------------");
                }

                accuracy = 5;
                {
                    var calculate = new СalculateIntegral();
                    sw.Reset();
                    sw.Start();
                    var y = СalculateIntegral.Calculate(func, start, end, n, accuracy);
                    if (y < 0)
                    {
                        y = Math.Abs(y);
                    }
                    sw.Stop();
                    var ts = sw.Elapsed.TotalMilliseconds;
                    Console.WriteLine($"Result [-10;10] f({str}) = { y } ");
                    Console.WriteLine($"Time:   {ts} milliseconds");
                    Console.WriteLine($"-------------------------");
                }

                accuracy = 1;
                {
                    var calculate = new СalculateIntegral();
                    sw.Reset();
                    sw.Start();
                    var y = СalculateIntegral.Calculate(func, start, end, n, accuracy);
                    if (y < 0)
                    {
                        y = Math.Abs(y);
                    }
                    sw.Stop();
                    var ts = sw.Elapsed.TotalMilliseconds;
                    Console.WriteLine($"Result [-10;10] f({str}) = { y } ");
                    Console.WriteLine($"Time:   {ts} milliseconds");
                    Console.WriteLine($"-------------------------");
                }

            }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }
    }
}
