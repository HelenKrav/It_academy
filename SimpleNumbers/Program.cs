using System;
using SimpleNumbersFrom;

namespace SimpleNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());

            var  simple = new SearchSimpleNumbers();
            Console.WriteLine("Количество простых чисел из диапазона 1-"+a);
            Console.WriteLine( simple.Search(a));

            
        }
    }
}
