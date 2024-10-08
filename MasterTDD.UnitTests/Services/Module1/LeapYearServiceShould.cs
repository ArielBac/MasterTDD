using FluentAssertions;
using MasterTDD.Services.Module1;

namespace MasterTDD.UnitTests.Services.Module1
{
    public class LeapYearServiceShould
    {
        [Fact]
        public void ReturnTrue_Given4()
        {
            var isLeapYear = LeapYearService.Verify(4);

            isLeapYear.Should().BeTrue();
        }

        [Fact]
        public void ReturnTrue_Given104()
        {
            var isLeapYear = LeapYearService.Verify(8);

            isLeapYear.Should().BeTrue();
        }

        [Fact]
        public void ReturnTrue_Given12()
        {
            var isLeapYear = LeapYearService.Verify(12);

            isLeapYear.Should().BeTrue();
        }

        [Fact]
        public void ReturnFalse_Given500()
        {
            var isLeapYear = LeapYearService.Verify(500);

            isLeapYear.Should().BeFalse();
        }

        [Fact]
        public void ReturnFalse_Given600()
        {
            var isLeapYear = LeapYearService.Verify(600);

            isLeapYear.Should().BeFalse();
        }

        [Fact]
        public void ReturnFalse_Given700()
        {
            var isLeapYear = LeapYearService.Verify(700);

            isLeapYear.Should().BeFalse();
        }

        [Fact]
        public void ReturnTrue_Given400()
        {
            var isLeapYear = LeapYearService.Verify(400);

            isLeapYear.Should().BeTrue();
        }

        [Fact]
        public void ReturnTrue_Given800()
        {
            var isLeapYear = LeapYearService.Verify(800);

            isLeapYear.Should().BeTrue();
        }

        [Fact]
        public void ReturnTrue_Given1200()
        {
            var isLeapYear = LeapYearService.Verify(1200);

            isLeapYear.Should().BeTrue();
        }
    }
}