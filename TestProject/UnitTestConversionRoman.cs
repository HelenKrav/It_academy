using Xunit;
using ConversionRoman;

namespace TestProject
{
    public class UnitTestConversionRoman
    {
        [Fact]
        public void ConversionFromRoman3()   
        {
            // arrange
            var con = new ConversionRoman.Conversion();

            // act
            // Объявляем массив
            char[] myArr = new char[3];

            // Инициализируем каждый элемент массива вручную
            myArr[0] = 'I';
            myArr[1] = 'I';
            myArr[2] = 'I';

            var a = con.Conv(myArr);

            // assert
            Assert.Equal(3, a);
        }

        [Fact]
        public void ConversionFromRoman9()
        {
            // arrange
            var con = new ConversionRoman.Conversion();

            // act
            // Объявляем массив
            char[] myArr = new char[2];

            // Инициализируем каждый элемент массива вручную
            myArr[0] = 'I';
            myArr[1] = 'X';
            var a = con.Conv(myArr);

            // assert
            Assert.Equal(9, a);
        }
    }
}
