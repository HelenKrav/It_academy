using System;
using It_academy;

namespace CalculateSquareRoots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            float a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Введите b:");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c:");
            float c = Convert.ToInt32(Console.ReadLine());


            var calculate = new CalculateSquareRootsAcc();

            calculate.Calculate(a, b, c);   

        }
    }
}
