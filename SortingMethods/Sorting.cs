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
                        Swap(ref mas[j + 1],ref mas[j]);
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




//        public double[] SortingQuickPivotLamuto_Median(double[] mas, int minIndex, int maxIndex)//массив, нижня и верхняя границы участка массива(в нашем случае начало и конец самого массива)
//        {
//            if (minIndex >= maxIndex)
//            {
//                return mas;
//            }
//            int pivot = GetPivotLamuto_Median(mas, minIndex, maxIndex);
//            SortingQuickPivotLamuto_Median(mas, minIndex, pivot - 1);
//            SortingQuickPivotLamuto_Median(mas, pivot + 1, maxIndex);
//            return mas;
//        }

//        /*
//         mid := (low + high) / 2
//if A[mid] < A[low]
//    swap A[low] with  A[mid]
//if A[high] < A[low]
//    swap A[low] with A[high]
//if A[mid] < A[high]
//    swap A[high] with A[mid]
//pivot := A[high]
//         */

//        //выбираем опорный элемент медиану
//        private static int GetPivotLamuto_Median(double[] array, int minIndex, int maxIndex) //разбиение Ламуто
//        {


//            var pivot = array[Pivot(array, minIndex, maxIndex)];
//            var marker = minIndex;
//            for (var j = minIndex; j < maxIndex - 1; j++)
//            {
//                if (array[j] < pivot)
//                {
//                    Swap(ref array[marker], ref array[j]);
//                    marker++;
//                }
//                Swap(ref array[marker], ref array[maxIndex]);

//            }
//            return marker;
//        }



       

//        //находим медиану
//        private static int Pivot(double[] array, int minIndex, int maxIndex)
//        {
//            int midian = (minIndex + maxIndex) / 2; 
//            if (array[midian] < array[minIndex])
//            {
//                Swap(ref array[minIndex], ref array[midian]);
//            }
//            if (array[maxIndex] < array[minIndex])
//            {
//                Swap(ref array[minIndex], ref array[maxIndex]);
//            }
//            if (array[midian] < array[maxIndex])
//            {
//                Swap(ref array[maxIndex], ref array[midian]);
//            }
//            return  maxIndex;
//        }

    }
}



