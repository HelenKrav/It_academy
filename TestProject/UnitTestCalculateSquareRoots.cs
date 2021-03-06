using System;
using It_academy;
using Xunit;

namespace TestProject
{
    public class UnitTestCalculateSquareRoots
    {
        /*
         ax2 + bx + c = 0

        D = b^2 - 4ac

        D < 0 : no roots : a != 0; b=0,a!=0,c!=0; b = 1,a = 0.25,c = 1.1

        D == 0 : one root =>  -b/2a : b = 1,a=0.25,c=1  

        D > 0 : (-b + Sqrt(D))/2a, (-b - Sqrt(D))/2a
            
                 
         */

        [Fact]
        public void Calculate_AIsZero_NoRoot()   //D < 0
        {
            // arrange
            var cut = new CalculateSquareRootsAcc();

            // act
            cut.Calculate(0, 0, 0);

            // assert
            Assert.Equal(RootExistanceEnum.NoRoot, cut.rootExistance);
        }

        [Fact]
        public void Calculate_BisZeroAisNotZeroCisNotZero_NoRoot()   
        {
            // arrange
            var cut = new CalculateSquareRootsAcc();

            // act
            cut.Calculate(1, 0, 1);

            // assert
            Assert.Equal(RootExistanceEnum.NoRoot, cut.rootExistance);
        }

        [Fact]
        public void Calculate_BSquareLess4ac_NoRoot()
        {
            // arrange
            var cut = new CalculateSquareRootsAcc();

            // act
            cut.Calculate(0.25f, 1, 1.1f);

            // assert
            Assert.Equal(RootExistanceEnum.NoRoot, cut.rootExistance);
        }

        [Fact]
        public void Calculate_BisZero_OneRoot()
        {
            // arrange
            var cut = new CalculateSquareRootsAcc();

            // act
            cut.Calculate(0.25f, 1, 1f);

            // assert
            Assert.Equal(RootExistanceEnum.OneRoot, cut.rootExistance);
        }

        [Fact]
        public void Calculate_BisZero_TwoRoot()
        {
            // arrange
            var cut = new CalculateSquareRootsAcc();

            // act
            cut.Calculate(2, 10, 2);

            // assert
            Assert.Equal(RootExistanceEnum.TwoRoot, cut.rootExistance);
        }




    }
}
