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
        public const int a = -10;
        public const int b = 10;

        public const string urov1 = "2*x+4";
        public const string urov2 = "2*x^2-10";
        public static string urov3 = "x^3";
        
        public double Calculate(Func<double, double> func)
        {
            for(int i = 10; i < 2;i +=10)
            {
              var sInterval = Func(0);
            }
            //double result = Convert.ToDouble(new DataTable().Compute("1 + 2 * 7", null));
          //  Console.WriteLine(result);
            return 0;
        }

        public double Func(double x)
        {
            return 2*x+10;

        }
        




    }
}
