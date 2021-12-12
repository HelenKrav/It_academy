using System;

namespace GeneratingAarraySymbol
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            var massCount =Convert.ToInt32(Console.ReadLine());
            string[] numbers = new string[massCount];
            for (int i = 0; i < massCount; i++)
            {
                Console.WriteLine("Введите элемент [" + i + "]");
                numbers[i] = Console.ReadLine();   
            }

            Console.WriteLine("_________");
            SearchNumber(numbers);

        }


        /*
  2. Если элемент массива делится на 3 вывести "Fizz"
  3. Если элемент массива делится на 5 вывести "Buzz"
  4. Если элемент массива делится на 3 и 5 вывести "FizzBuzz"
         */
        public static void SearchNumber(string[] mass)
        {
            string three = "Fizz";
            string fife = "Buzz";
            string both = "FizzBuzz";
            for (int i = 0;i < mass.Length;i++)
            {
                if (Convert.ToInt32(mass[i])%3==0 & Convert.ToInt32(mass[i])% 5 == 0)
                {
                    mass[i] = both;
                    Console.WriteLine(mass[i]);
                }
                else if (Convert.ToInt32(mass[i]) % 3==0)
                {
                    mass[i] = three;
                    Console.WriteLine(mass[i]);
                }
                else if(Convert.ToInt32(mass[i]) % 5 == 0)
                {
                    mass[i] = fife;
                    Console.WriteLine(mass[i]);
                }
                else
                {
                    Console.WriteLine(mass[i]);
                }
            }
            
            

        }
    }
}
