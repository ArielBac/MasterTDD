using FluentAssertions;
using MasterTDD.Services;

namespace MasterTDD.UnitTests
{
    public class LeapYearServiceShould
    {
        [Fact]
        public void ReturnTrue_Given4()
        {
            var isLeapYear = LeapYearService.Verify(4);

            isLeapYear.Should().BeTrue();
        }
    }
}