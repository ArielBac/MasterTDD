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
        public void ReturnSumGivenTwoNumbers(string numbers, int expected)
        {
            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(expected);
        }
    }
}
