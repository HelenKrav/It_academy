using System;
using System.Collections.Generic;
using System.Text;

namespace SortingMethods
{
    public class Sorting
    {
        //метод обмена, чтобы не дублировать код во всех методах
        private static void Swap(ref double leftItem, ref double rightItem)    
        {
            double temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;

        }

        //сортировка пузырьком
        public  double[] SortingBubble(double[] mas)
        {
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    for (int j = 0; j < mas.Length - i - 1; j++)
                    {
                        if (mas[j + 1] < mas[j])
                        {
                            Swap(ref mas[j + 1], ref mas[j]);
                        }
                    }
                }
                return mas;
        }

        //быстрая сортировка
        public double[] SortingQuickPivotLamuto(double[] mas, int minIndex, int maxIndex)//массив, нижня и верхняя границы участка массива(в нашем случае начало и конец самого массива)
        {
            if (minIndex >= maxIndex)
            {
                return mas;
            }
            int pivot = GetPivotLamuto(mas, minIndex, maxIndex);
            SortingQuickPivotLamuto(mas, minIndex, pivot-1);
            SortingQuickPivotLamuto(mas, pivot + 1, maxIndex);
            return mas;
        }

        //опорным выбиратся первый элемент
        private static int GetPivotLamuto(double[] array, int minIndex, int maxIndex) //разбиение Ламуто
        {
            int marker = minIndex;//выбор элемента разделения массива
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex]) //array[maxIndex] is pivot
                {
                    Swap(ref array[marker], ref array[i]);
                    marker += 1;
                }
            }
            Swap(ref array[marker], ref array[maxIndex]);

            return marker;
        }
    }
}



