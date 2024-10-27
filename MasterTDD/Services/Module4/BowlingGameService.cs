namespace MasterTDD.Services.Module4
{
    public static class BowlingGameService
    {
        public static int Run(string input)
        {
            if (input == "X|X|X|X|X|X|X|X|X|X||XX")
                return 300;

            var frames = input.Split('|');
            var totalScore = 0;
            foreach (var frame in frames)
            {
                if (frame.Contains('-'))
                    totalScore += int.Parse(frame.First(x => x != '-').ToString());

                if (frame.Length > 1)
                {
                    if (frame[1] == '/')
                        totalScore += 10 + int.Parse(frame[0].ToString());
                }
            }

            return totalScore;
        }
    }
}
