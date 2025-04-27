using FluentAssertions;
using MasterTDD.Services.Module6;

namespace MasterTDD.UnitTests.Services.Module6
{
    public class OddOrEvenDetectorServiceShould
    {
        private readonly OddOrEvenDetectorService _service;
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
    }
}
