using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(5, 6, 4, 15)]
        [InlineData(10, -10, 0, 0)]
        [InlineData(7, 6, 5, 18)]
        [InlineData(21, 42, 1, 64)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calc = new Calculator();

            //Act
            int actual = calc.Add(num1, num2, num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]//Add test data <-------
        [InlineData(10, 4, 6)]
        [InlineData(100, 99, 1)]
        [InlineData(45, 15, 30)]
        [InlineData(2022, 1998, 24)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();

            //Act
            int actual = calc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 5, 15)]//Add test data <-------
        [InlineData(5, 0, 0)]
        [InlineData(12, 11, 132)]
        [InlineData(-9, 9, -81)]
        [InlineData(10, 9, 90)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();

            //Act
            int actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9, 3, 3)]//Add test data <-------
        [InlineData(81, 9, 9)]
        [InlineData(100, 10, 10)]
        [InlineData(0, -84, 0)]
        [InlineData(75, 15, 5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
