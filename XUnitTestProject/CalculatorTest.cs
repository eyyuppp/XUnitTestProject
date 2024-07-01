using XUnitSample;

namespace XUnitTestProject
{
    public class CalculatorTest
    {
        Calculator sut = new Calculator();
        //test etmek için  ‘View’ -> ‘Test Explorer’ açıp test edebilirsin
        [Fact]
        public void add()
        {
            // Arrange
            int number1 = 5;
            int number2 = 15;
            // Act
            int result1 = sut.Addition(number1, number2);
            // Assert
            Assert.Equal(20, result1);

        }

        [Fact]
        public void Multiplication()
        {
            // Arrange
            int number1 = 5;
            int number2 = 15;
            // Act
            int result2 = sut.Multiplication(number1, number2);
            // Assert
            Assert.Equal(75, result2);
        }
    }
}