using FluentAssertions;
using MasterTDD.Services.Module6;
using Moq;

namespace MasterTDD.UnitTests.Services.Module6
{
    public class OddOrEvenDetectorServiceShould
    {
        private readonly OddOrEvenDetectorService _service;
        private readonly Mock<IRandomGenerator> _randomGeneratorMock = new();
        public OddOrEvenDetectorServiceShould()
        {
            _service = new OddOrEvenDetectorService(_randomGeneratorMock.Object);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(99)]
        public void ReturnTrueIfOdd(int oddNumber)
        {
            _randomGeneratorMock.Setup(x => x.GetRandomBetween1And100()).Returns(oddNumber);

            var isOdd = _service.IsRandomNumberOdd();

            isOdd.Should().BeTrue();
        }

        [Fact]
        public void CallGetRandomBetween1And100()
        {
            var isOdd = _service.IsRandomNumberOdd();

            _randomGeneratorMock.Verify(x => x.GetRandomBetween1And100(), Times.Once);
        }

        [Fact]
        public void ReturnFalseIfEven()
        {
            _randomGeneratorMock.Setup(x => x.GetRandomBetween1And100()).Returns(2);

            var isOdd = _service.IsRandomNumberOdd();

            isOdd.Should().BeFalse();
        }
    }
}
