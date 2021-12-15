using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject
{
    public class UnitTestSimpleNumbers
    {
        [Fact]
        public void Simple()
        {
            // arrange
            var con = new SimpleNumbersFrom.SearchSimpleNumbers();

            // act

            int a = con.Search(5);

            // assert
            Assert.Equal(3, a);
        }
    }
}
