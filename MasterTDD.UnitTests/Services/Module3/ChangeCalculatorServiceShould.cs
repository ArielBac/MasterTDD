using FluentAssertions;
using MasterTDD.Services.Module3;

namespace MasterTDD.UnitTests.Services.Module3
{
    public class ChangeCalculatorServiceShould
    {
        [Theory]
        [InlineData(100, 100, new double[] { })]
        [InlineData(50, 100, new double[] { 50 })]
        [InlineData(20, 40, new double[] { 20 })]
        [InlineData(20, 30, new double[] { 10 })]
        [InlineData(25, 100, new double[] { 50, 20, 5 })]
        [InlineData(25, 26, new double[] { 1 })]
        [InlineData(25, 27, new double[] { 1, 1 })]
        [InlineData(25.5, 26, new double[] { 0.5 })]
        public void ReturnValidChangeArray(double totalCost, double totalPaid, double[] expected)
        {
            var result = ChangeCalculatorService.GetChange(totalCost, totalPaid);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
