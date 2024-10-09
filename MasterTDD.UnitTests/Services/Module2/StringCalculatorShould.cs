using FluentAssertions;
using MasterTDD.Services.Module2;

namespace MasterTDD.UnitTests.Services.Module2
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroWhenEmptyString()
        {
            string numbers = string.Empty;

            var result = StringCalculatorService.Add(numbers);

            result.Should().Be(0);
        }
    }
}
