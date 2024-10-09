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

        [Fact]
        public void Return0Given0()
        {
            string numbers = "0";

            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(0);
        }

        [Fact]
        public void Return1Given1()
        {
            string numbers = "1";

            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(1);
        }

        [Fact]
        public void Return2Given2()
        {
            string numbers = "2";

            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(2);
        }
    }
}
