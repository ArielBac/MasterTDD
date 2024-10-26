using FluentAssertions;
using MasterTDD.Services.Module4;

namespace MasterTDD.UnitTests.Services.Module4
{
    public class BowlingGameServiceShould
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        public void Return300Score(string input, int expectedScore)
        {
            var score = BowlingGameService.Run(input);

            score.Should().Be(expectedScore);
        }
    }
}
