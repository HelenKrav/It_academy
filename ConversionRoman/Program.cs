using System;
using ConversionRoman;

namespace ConversionRoman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в римском формате:");
            string roman = Console.ReadLine();
            char[] arr = roman.ToCharArray();

            var conversion = new Conversion();
            Console.WriteLine(conversion.Conv(arr));
        }
    }
}
