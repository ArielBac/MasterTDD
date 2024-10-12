using FluentAssertions;
using MasterTDD.Services.Module2;

namespace MasterTDD.UnitTests.Services.Module2
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroGivenEmptyString()
        {
            string numbers = string.Empty;

            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(0);
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void ReturnNumberGivenSingleNumber(string number, int expected)
        {
            string numbers = number;

            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("0,1", 1)]
        [InlineData("1,1", 2)]
        [InlineData("2,3", 5)]
        [InlineData("0,1,2", 3)]
        [InlineData("0,1,2,3", 6)]
        [InlineData("0,1,2,3,4", 10)]
        public void ReturnSumGivenMoreThanOneNumberSplitByCommas(string numbers, int expected)
        {
            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1\n2\n3", 6)]
        [InlineData("1\n2,3,4", 10)]
        [InlineData("1\n2\n3\n4", 10)]
        [InlineData("1\n2\n3\n4,10,25", 45)]
        [InlineData("1\n2\n3\n4,5\n10", 25)]
        public void ReturnSumGivenMoreThanOneNumberSplitByNewLine(string numbers, int expected)
        {
            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        [InlineData("//.\n1.2", 3)]
        [InlineData("///\n1/2", 3)]
        [InlineData("//.\n1.2.9", 12)]
        [InlineData("//x\n1x2x8", 11)]
        [InlineData("//-\n1-2-4", 7)]
        [InlineData("//-\n1-2,3-1\n2", 9)]
        [InlineData("//.\n1.2,4", 7)]
        public void ReturnSumGivenMoreThanOneNumberSplitByCustomDelimiter(string numbers, int expected)
        {
            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("2\n-1")]
        [InlineData("2,-1")]
        [InlineData("-3\n1")]
        [InlineData("-3,-2")]
        [InlineData("-3,-2,-1")]
        [InlineData("//.\n-3.-2.-1")]
        [InlineData("//;\n3;2;-1")]
        public void ThrowExceptionGivenNegativeNumbers(string numbers)
        {
            var result = () => StringCalculatorService.Add(numbers);

            result.Should().Throw<Exception>();
        }

        [Theory]
        [InlineData("-1")]
        public void ThrowExceptionGivenNegativeNumbersWithMessage(string numbers)
        {
            var result = () => StringCalculatorService.Add(numbers);

            var exception = result.Should().Throw<Exception>().Which;

            exception.Message.Should().StartWith("Negatives not allowed");
            exception.Message.Should().ContainAll(numbers);
        }
    }
}
