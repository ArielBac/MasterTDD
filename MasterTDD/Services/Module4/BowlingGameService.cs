
namespace MasterTDD.Services.Module4
{
    public static class BowlingGameService
    {
        private static int _totalScore;
        private static bool IsStrike(string frame) => frame == "X";
        private static bool IsSpare(string frame) => frame.Contains('/');

        public static int Run(string input)
        {
            var inputs = input.Split("||");
            var frames = inputs[0].Split('|');
            var bonus = inputs[1];

            _totalScore = 0;

            for (var frameIndex = 0; frameIndex < frames.Length; frameIndex++)
            {
                if (IsStrike(frames[frameIndex]))
                {
                    AddStrikeScore(frames, bonus, frameIndex);
                }
                else if (IsSpare(frames[frameIndex]))
                {
                    AddSpareScore(frames, bonus, frameIndex);
                }
                else
                {
                    AddNextTwoScores(frames[frameIndex][0], frames[frameIndex][1]);
                }
            }

            return _totalScore;
        }

        private static void AddStrikeScore(string[] frames, string bonus, int frameIndex)
        {
            _totalScore += 10;

            if (frameIndex == 8)
            {
                AddNextTwoScores(frames[frameIndex + 1][0], bonus[0]);
            }
            else if (frameIndex == 9)
            {
                AddNextTwoScores(bonus[0], bonus[1]);
            }
            else if (IsStrike(frames[frameIndex + 1]))
            {
                _totalScore += 10;
                AddSingleScore(frames[frameIndex + 2][0]);
            }
            else if (IsSpare(frames[frameIndex + 1]))
            {
                _totalScore += 10;
            }
            else
            {
                AddNextTwoScores(frames[frameIndex + 1][0], frames[frameIndex + 1][1]);
            }
        }

        private static void AddSpareScore(string[] frames, string bonus, int frameIndex)
        {
            _totalScore += 10;

            if (frameIndex == 9)
            {
                AddSingleScore(bonus[0]);
            }
            else
            {
                AddSingleScore(frames[frameIndex + 1][0]);
            }

        }


        private static void AddNextTwoScores(char first, char second)
        {
            AddSingleScore(first);
            AddSingleScore(second);
        }

        private static void AddSingleScore(char input)
        {
            if (input == 'X')
            {
                _totalScore += 10;
                return;
            }

            var isParsedScore = false;

            isParsedScore = int.TryParse(input.ToString(), out int parsedScore);

            if (isParsedScore)
                _totalScore += parsedScore;
        }
    }
}
