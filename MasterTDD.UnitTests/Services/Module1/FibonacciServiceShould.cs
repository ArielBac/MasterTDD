using FluentAssertions;
using MasterTDD.Services.Module1;

namespace MasterTDD.UnitTests.Services.Module1
{
    public class FibonacciServiceShould
    {
        [Fact]
        public void Return1_AtPosition1()
        {
            var fibonacciNumber = FibonacciService.GetNumberAtPosition(1);

            fibonacciNumber.Should().Be(0);
        }
    }
}
