using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNumbersFrom
{
    /* 
     простые числа делятся на себя и на 1
     */


    public class SearchSimpleNumbers
    {
        public void Search(string numberFromConcole)
        {
            int count = 0;
            int number_int = Convert.ToInt32(numberFromConcole); 
            
            for (int num = 2; num <= number_int; num++) //прошагиваем каждое число их диапазона 
                {
                    bool b = true;
                    for (int j = 2; j < num; j++)
                    {
                        if (num % j == 0 & num % 1 == 0)
                        {
                            b = false;
                        }
                    }
                    if (b)
                    {
                        count++;
                    }
                }
            Console.WriteLine(count);
        }
    }
}
