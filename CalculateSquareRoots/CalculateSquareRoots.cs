using System;
using System.Collections.Generic;
using System.Text;

namespace It_academy
{
    public enum RootExistanceEnum
    {
        NotDefined,
        NoRoot,
        OneRoot,
        TwoRoot
    }

    public class CalculateSquareRootsAcc
    {
        public float x1, x2;

        public RootExistanceEnum rootExistance = RootExistanceEnum.NotDefined;

        public void Calculate(float a, float b, float c)
        {
            if (a == 0)
            {
                rootExistance = RootExistanceEnum.NoRoot;
                return;
            }

            float d = b * b - 4 * a * c;

            if (d < 0)
            {
                rootExistance = RootExistanceEnum.NoRoot;
                Console.WriteLine("Дискриминант меньше 0, корней нет");
            }
            else if (d == 0)
            {
                rootExistance = RootExistanceEnum.OneRoot;
                x1 = -b / (2 * a);
                Console.WriteLine("Дискриминант равен 0, корень x = " + x1);
            }
            else
            {
                rootExistance = RootExistanceEnum.TwoRoot;
                x1 = (float)((-b + Math.Sqrt(d)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("Дискриминант больше 0, корень x1 = " + x1);
                Console.WriteLine("Дискриминант больше 0, корень x2 = " + x2);
            }

        }
    }
}
