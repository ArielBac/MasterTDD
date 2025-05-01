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
            _service = new OddOrEvenDetectorService();
        }

        [Fact]
        public void ReturnTrueIfOdd()
        {
            var isOdd = _service.IsRandomNumberOdd();

            isOdd.Should().BeTrue();
        }

        [Fact]
        public void CallGetRandomBetween1And100()
        {
            var isOdd = _service.IsRandomNumberOdd();

            _randomGeneratorMock.Verify(x => x.GetRandomBetween1And100(), Times.Once);
        }
    }
}
