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

        [Fact]
        public void Return1Given0And1()
        {
            string numbers = "0,1";

            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(1);
        }

        [Fact]
        public void Return2Given1And1()
        {
            string numbers = "1,1";

            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(2);
        }

        [Fact]
        public void Return5Given2And3()
        {
            string numbers = "2,3";

            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(5);
        }
    }
}
