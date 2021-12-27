using SortingMethods;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject
{
    public class UnitTestSortingMethod
    {
        [Fact]
        public void SortBubbleMethodTest()
        {

            var bubble = new Sorting();
            var mass = new double[] {3,5,2,9,7,4,8,0};
            var result = bubble.SortingBubble(mass);
            var expected = new double[] {0, 2, 3, 4, 5, 7, 8, 9 };

            Assert.Equal(expected, result);

        }

        [Fact]
        public void SortQuickMethodPovitLamitoTest()
        {

            var bubble = new Sorting();
            var mass = new double[] { 3, 5, 2, 7, 4 };
            var result = bubble.SortingQuickPivotLamuto(mass,0,mass.Length-1);
            var expected = new double[] { 2, 3, 4, 5, 7 };

            Assert.Equal(expected, result);

        }

        //[Fact]
        //public void SortQuickMethodPovitMedianTest()
        //{

        //    var bubble = new Sorting();
        //    var mass = new double[] { 3, 5, 2, 7, 4 };
        //    var result = bubble.SortingQuickPivotLamuto_Median(mass, 0, mass.Length - 1);
        //    var expected = new double[] { 2, 3, 4, 5, 7 };

        //    Assert.Equal(expected, result);

        //}
    }
}
