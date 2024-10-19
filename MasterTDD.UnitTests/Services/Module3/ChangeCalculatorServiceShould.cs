using FluentAssertions;
using MasterTDD.Services.Module3;

namespace MasterTDD.UnitTests.Services.Module3
{
    public class ChangeCalculatorServiceShould
    {
        [Theory]
        [InlineData(100, 100, new double[] { 0 })]
        [InlineData(50, 100, new double[] { 50 })]
        public void ReturnValidChangeArray(double totalCost, double totalPaid, double[] expected)
        {
            var result = ChangeCalculatorService.GetChange(totalCost, totalPaid);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
