
namespace MasterTDD.Services.Module4
{
    public static class BowlingGameService
    {
        private static int _totalScore;

        public static int Run(string input)
        {
            var inputs = input.Split("||");
            var frames = inputs[0].Split('|');
            var bonus = inputs[1];

            _totalScore = 0;

            for (var i = 0; i < frames.Length; i++)
            {
                if (frames[i] == "X")
                {
                    _totalScore += 10;

                    if (i == 8)
                    {
                        AddScore(frames[i + 1][0]);
                        AddScore(bonus[0]);
                        continue;
                    }

                    if (i == 9)
                    {
                        AddScore(bonus[0]);
                        AddScore(bonus[1]);
                        continue;
                    }

                    if (frames[i + 1][0] == 'X')
                    {
                        _totalScore += 10;
                        AddScore(frames[i + 2][0]);
                        continue;
                    }
                    else if (frames[i + 1].Contains('/'))
                    {
                        _totalScore += 10;
                        continue;
                    }

                    AddScore(frames[i + 1][0]);
                    AddScore(frames[i + 1][1]);
                }
                else if (frames[i].Contains('/'))
                {
                    _totalScore += 10;

                    if (i == 9)
                    {
                        AddScore(bonus[0]);
                        break;
                    }

                    AddScore(frames[i + 1].FirstOrDefault(char.IsNumber));
                }
                else
                {
                    AddScore(frames[i][0]);
                    AddScore(frames[i][1]);
                }
            }

            return _totalScore;
        }

        private static void AddScore(char input)
        {
            if (input == '-')
                return;

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
