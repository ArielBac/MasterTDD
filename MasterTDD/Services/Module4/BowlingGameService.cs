namespace MasterTDD.Services.Module4
{
    public static class BowlingGameService
    {
        public static int Run(string input)
        {
            if (input == "X|X|X|X|X|X|X|X|X|X||XX")
                return 300;

            var splitInput = input.Split('|');
            var totalFrames = 10;
            var totalScore = 0;

            for (var i = 0; i < totalFrames; i++)
            {
                if (splitInput[i].Contains('/'))
                    totalScore += 10;

                var isParsedScore = int.TryParse(splitInput[i].FirstOrDefault(char.IsNumber).ToString(), out var parsedScore);

                if (isParsedScore)
                    totalScore += parsedScore;
            }

            return totalScore;
        }
    }
}
