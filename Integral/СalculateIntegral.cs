using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Integral
{
    
    
    /*
    Рассчать интеграл функции на интервале от -10 до 10 с заданной точностью.Вернуть значение интеграла, время вычисления, кол-во итераций для каждого значение точности.
- произвольная функция задается в консоли в виде:
	- 2*x+4
	- 2*x^2-10
	- x^3
- точность 10%, 5%, 1%
- Тест не нужен
- Math.Abs(y) - вернет результат по модулю
- StopWatch()
     */
    

    internal class СalculateIntegral
    {
        public const int start = -10;
        public const int end = 10;

        
        public static double Calculate(Func<double, double> func, double a, double b, int n, int accuracy)
        {
            var acc =  accuracy/100d;
            var sum = 0d;
            var result2 = 0d;
            var result = 0d;
            int g = 1;
            
            for (int i = 0; i < 1;i++)
            {
                var h = (b - a) / n;
                for (var j = 0; j <= n - 1; j++)
                {
                    var x = a + j * h;
                    sum += Math.Round(func(x), 2);  // сумма всех площадей на n отрезках
                }
                result = Math.Round(h * sum, 2); 
                if (Math.Abs(result - result2) > acc) //сбрасывем всё и ищем следующщий результат при n*2 
                { 
                    n *= 2;
                    result2 = result;
                    sum = 0;
                    i--;
                    g++;
                }
            }
            Console.WriteLine($"Accuracy is {accuracy} %");
            Console.WriteLine($"Step is {n}");
            Console.WriteLine($"Count iteration is {g}");
            return result;
        }



    }
}
