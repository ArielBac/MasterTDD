using FluentAssertions;
using MasterTDD.Services.Module1;

namespace MasterTDD.UnitTests.Services.Module1
{
    public class FibonacciServiceShould
    {
        [Fact]
        public void Return0_AtPosition1()
        {
            var fibonacciNumber = FibonacciService.GetNumberAtPosition(1);

            fibonacciNumber.Should().Be(0);
        }

        [Fact]
        public void Return1_AtPosition2()
        {
            var fibonacciNumber = FibonacciService.GetNumberAtPosition(2);

            fibonacciNumber.Should().Be(1);
        }

        [Fact]
        public void Return1_AtPosition3()
        {
            var fibonacciNumber = FibonacciService.GetNumberAtPosition(3);

            fibonacciNumber.Should().Be(1);
        }

        [Fact]
        public void Return2_AtPosition4()
        {
            var fibonacciNumber = FibonacciService.GetNumberAtPosition(4);

            fibonacciNumber.Should().Be(2);
        }

        [Fact]
        public void Return3_AtPosition5()
        {
            var fibonacciNumber = FibonacciService.GetNumberAtPosition(5);

            fibonacciNumber.Should().Be(3);
        }

        [Fact]
        public void Return5_AtPosition6()
        {
            var fibonacciNumber = FibonacciService.GetNumberAtPosition(5);

            fibonacciNumber.Should().Be(3);
        }
    }
}
