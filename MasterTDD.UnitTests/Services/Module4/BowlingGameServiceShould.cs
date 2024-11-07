using FluentAssertions;
using MasterTDD.Services.Module4;

namespace MasterTDD.UnitTests.Services.Module4
{
    public class BowlingGameServiceShould
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [InlineData("X|X|X|X|X|X|X|X|X|X||X5", 295)]
        [InlineData("X|X|X|X|X|X|X|X|X|X||5X", 290)]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", 90)]
        [InlineData("-9|-9|-9|-9|-9|-9|-9|-9|-9|-9||", 90)]
        [InlineData("8-|8-|8-|8-|8-|8-|8-|8-|8-|8-||", 80)]
        [InlineData("-8|-8|-8|-8|-8|-8|-8|-8|-8|-8||", 80)]
        [InlineData("5-|5-|5-|5-|6-|6-|7-|7-|7-|7-||", 60)]
        [InlineData("-5|-5|-5|-5|-6|-6|-7|-7|-7|-7||", 60)]
        [InlineData("4/|4/|4/|4/|4/|4/|4/|4/|4/|4/||4", 140)]
        [InlineData("4/|4/|4/|4/|4/|4/|4/|4/|4/|4/||8", 144)]
        [InlineData("5/|5/|5/|5/|5/|5/|5/|5/|5/|5/||5", 150)]
        [InlineData("5/|5/|5/|5/|5/|5/|5/|5/|5/|5/||7", 152)]
        [InlineData("6/|6/|6/|6/|6/|6/|6/|6/|6/|6/||6", 160)]
        [InlineData("6/|6/|6/|6/|6/|6/|6/|6/|6/|6/||7", 161)]
        [InlineData("X|7/|9-|X|-8|8/|-6|X|X|X||81", 167)]
        [InlineData("52|7/|9-|X|7/|8/|X|51|X|X||81", 162)]
        [InlineData("X|3/|X|81|4/|X|X|8/|13|8/||X", 171)]
        [InlineData("X|81|X|81|4/|X|X|X|13|8/||X", 165)]
        public void ReturnTotalScore(string input, int expectedScore)
        {
            var score = BowlingGameService.Run(input);

            score.Should().Be(expectedScore);
        }
    }
}
