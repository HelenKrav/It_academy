using System;
using System.Linq.Expressions;

namespace Integral
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите функцию для вычисления с праметром х :");
            var str = Console.ReadLine();

            try
            {
                var x = Expression.Parameter(typeof(double), "x");
                var expression = ParseFormula.DynamicExpression.ParseLambda(
                    new ParameterExpression[] { x },
                    typeof(double),
                    str);

                var func = (Func<double,double>)expression.Compile();

                var calculate = new СalculateIntegral();
                calculate.Calculate(func);


                var y = func(2);

                Console.Write($"result f(2) = { y }");

            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }



           //Console.ReadLine();
           // Console.WriteLine("Вернуть значение интеграла");
           // Console.WriteLine("Вернуть время вычисления");
            //Console.WriteLine("Вернуть кол-во итераций для каждого значение точности");
           // Console.WriteLine("________");

           //  integral.Calculate("www");
            //Console.WriteLine();
        }
    }
}
