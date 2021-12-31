using System;
using System.Diagnostics;

namespace SortingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Код для генерации массива:
            
            var rnd = new Random();
            var array = new double[(int)1e7]; //1e2
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * 10;
            }
            

            var sw = new Stopwatch();
            TimeSpan span = sw.Elapsed;

            Console.WriteLine("----------------------");
            Console.WriteLine("____Sorting Methods___");
            Console.WriteLine("----------------------");

            var arrayForBubbleMethod = array;
            Console.WriteLine("____Bubble Sorting____");
            var methodBubble = new Sorting();
            sw.Start();
            var resultMethodBubble = methodBubble.SortingBubble(arrayForBubbleMethod);
            sw.Stop();
            TimeSpan spanFromBubble = sw.Elapsed;
            Console.WriteLine($"Time {spanFromBubble} ");
            Console.WriteLine("----------------------");
            
            var arrayForQuickMethod = array;
            Console.WriteLine("____QuickSort - First element_________");
            var methodQuick = new Sorting();
            sw.Reset();
            sw.Start();
            var resultMethodQuick = methodQuick.SortingQuickPivotLamuto(arrayForQuickMethod, 0, arrayForQuickMethod.Length-1);
            sw.Stop();
            TimeSpan spanFromQuick = sw.Elapsed;
            Console.WriteLine($"Time {spanFromQuick}");
            Console.WriteLine("----------------------");
        }
    }
}
