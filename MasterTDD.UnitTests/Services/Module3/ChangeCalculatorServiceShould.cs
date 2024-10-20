using FluentAssertions;
using MasterTDD.Services.Module3;

namespace MasterTDD.UnitTests.Services.Module3
{
    public class ChangeCalculatorServiceShould
    {
        [Theory]
        [InlineData(100, 100, new double[] { })]
        [InlineData(25, 26, new double[] { 1 })]
        [InlineData(20, 40, new double[] { 20 })]
        [InlineData(20, 30, new double[] { 10 })]
        [InlineData(50, 100, new double[] { 50 })]
        [InlineData(25, 100, new double[] { 50, 20, 5 })]
        [InlineData(25, 27, new double[] { 1, 1 })]
        [InlineData(25.5, 26, new double[] { 0.5 })]
        [InlineData(25.75, 26, new double[] { 0.25 })]
        [InlineData(25.90, 26, new double[] { 0.1 })]
        [InlineData(25.95, 26, new double[] { 0.05 })]
        [InlineData(25.99, 26, new double[] { 0.01 })]
        [InlineData(224.99, 500, new double[] { 100, 100, 50, 20, 5, 0.01 })]
        [InlineData(225.01, 500, new double[] { 100, 100, 50, 20, 1, 1, 1, 1, 0.5, 0.25, 0.1, 0.1, 0.01, 0.01, 0.01, 0.01 })]
        public void ReturnValidChangeArray(double totalCost, double totalPaid, double[] expected)
        {
            var result = ChangeCalculatorService.GetChange(totalCost, totalPaid);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
