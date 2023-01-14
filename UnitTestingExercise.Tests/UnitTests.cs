using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-2, 3, -5, -4)]
        [InlineData(0, 0, 0, 0)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var cal = new Calculator();


            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = cal.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(10, 2, 8)]
        [InlineData(0, 0, 0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var cal = new Calculator();
            //Act
            var actual = cal.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 10, 100)]
        [InlineData(-12, 12, -144)]
        [InlineData(0, 0, 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var cal = new Calculator();
            //Act
            var actual = cal.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 1, 10)]
        [InlineData(15, 3, 5)]
        [InlineData(10, 0, 0)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var cal = new Calculator();
            //Act
            var actual = cal.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
