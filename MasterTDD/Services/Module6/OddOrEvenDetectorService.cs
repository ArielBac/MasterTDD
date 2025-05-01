namespace MasterTDD.Services.Module6
{
    public class OddOrEvenDetectorService(IRandomGenerator randomGenerator)
    {
        public bool IsRandomNumberOdd()
        {
            var randomNumber = randomGenerator.GetRandomBetween1And100();

            return randomNumber % 2 != 0;
        }
    }
}
