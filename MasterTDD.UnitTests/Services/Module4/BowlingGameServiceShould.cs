using FluentAssertions;
using MasterTDD.Services.Module4;

namespace MasterTDD.UnitTests.Services.Module4
{
    public class BowlingGameServiceShould
    {
        [Fact]
        public void Return300Score()
        {
            var score = BowlingGameService.Run("X|X|X|X|X|X|X|X|X|X||XX");

            score.Should().Be(300);
        }
    }
}
