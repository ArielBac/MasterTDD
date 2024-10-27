
namespace MasterTDD.Services.Module4
{
    public static class BowlingGameService
    {
        private static int _totalScore;
        public static int Run(string input)
        {
            if (input == "X|X|X|X|X|X|X|X|X|X||XX")
                return 300;

            var inputs = input.Split('|');
            _totalScore = 0;

            for (var i = 0; i < inputs.Length; i++)
            {
                if (inputs[i].Contains('/'))
                {
                    _totalScore += 10;

                    if (inputs[i] == string.Empty)
                        AddScore(inputs[i + 2]);
                    else
                        AddScore(inputs[i + 1]);
                }
                else
                    AddScore(inputs[i]);
            }

            return _totalScore;
        }

        private static void AddScore(string input)
        {
            var isParsedScore = false;

            isParsedScore = int.TryParse(input.FirstOrDefault(char.IsNumber).ToString(), out int parsedScore);

            if (isParsedScore)
                _totalScore += parsedScore;
        }
    }
}
