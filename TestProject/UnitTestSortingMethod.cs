using SortingMethods;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject
{
    public class UnitTestSortingMethod
    {
        [Fact]// неотсортированный массив
        public void SortBubbleMethodTest_NotSortingMassiv()
        {

            var bubble = new Sorting();
            var mass = new double[] {3,5,2,9,7,4,8,0};
            var result = bubble.SortingBubble(mass);
            var expected = new double[] {0, 2, 3, 4, 5, 7, 8, 9 };

            Assert.Equal(expected, result);

        }

        [Fact]// пустой массив
        public void SortBubbleMethodTest_EmptyMassiv()
        {

            var bubble = new Sorting();
            var mass = new double[0] {} ;
            var result = bubble.SortingBubble(mass);
            var expected = new double[] {};

            Assert.Equal(expected, result);

        }


        [Fact]// отсортированный массив
        public void SortBubbleMethodTest_SortingMassiv()
        {

            var bubble = new Sorting();
            var mass = new double[] { 0, 2, 3, 4, 5, 7, 8, 9 };
            var result = bubble.SortingBubble(mass);
            var expected = new double[] { 0, 2, 3, 4, 5, 7, 8, 9 };

            Assert.Equal(expected, result);

        }


        [Fact] // неотсортированный массив
        public void SortQuickMethodPovitLamitoTest_NotSortingMassiv()
        {

            var bubble = new Sorting();
            var mass = new double[] { 3, 5, 2, 7, 4 };
            var result = bubble.SortingQuickPivotLamuto(mass,0,mass.Length-1);
            var expected = new double[] { 2, 3, 4, 5, 7 };

            Assert.Equal(expected, result);

        }

        [Fact] // пустой массив
        public void SortQuickMethodPovitLamitoTest_EmptyMassiv()
        {

            var bubble = new Sorting();
            var mass = new double[0] {};
            var result = bubble.SortingQuickPivotLamuto(mass, 0, mass.Length - 1);
            var expected = new double[] {};

            Assert.Equal(expected, result);

        }


        [Fact] // отсортированный массив
        public void SortQuickMethodPovitLamitoTest_SortingMassiv()
        {

            var bubble = new Sorting();
            var mass = new double[] { 2, 3, 4, 5, 7 };
            var result = bubble.SortingQuickPivotLamuto(mass, 0, mass.Length - 1);
            var expected = new double[] { 2, 3, 4, 5, 7 };

            Assert.Equal(expected, result);

        }


    }
}
