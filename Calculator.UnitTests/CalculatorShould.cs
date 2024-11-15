namespace Calculator.UnitTests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Return_AdditionOfTwoNumbers_WhenAdd()
        {
            //Arrange
            var expectedAddition = 7;
            var number1 = 3;
            var number2 = 4;

            //Act
            var actualAddition = _calculator.Add(number1, number2);

            //Assert
            Assert.Equal(expectedAddition, actualAddition);
        }

        [Fact]
        public void Return_SubstractionOfTwoNumbers_WhenSubstract()
        {
            //Arrange
            var expectedAddition = -1;
            var number1 = 3;
            var number2 = 4;

            //Act
            var actualAddition = _calculator.Substract(number1, number2);

            //Assert
            Assert.Equal(expectedAddition, actualAddition);
        }

        [Fact]
        public void Return_MultiplicationOfTwoNumbers_WhenMultiply()
        {
            //Arrange
            var expectedAddition = 12;
            var number1 = 3;
            var number2 = 4;

            //Act
            var actualAddition = _calculator.Multiply(number1, number2);

            //Assert
            Assert.Equal(expectedAddition, actualAddition);
        }
    }
}