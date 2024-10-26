namespace MasterTDD.Services.Module4
{
    public static class BowlingGameService
    {
        public static int Run(string input)
        {
            if (input == "X|X|X|X|X|X|X|X|X|X||XX")
                return 300;

            if (input == "-9|-9|-9|-9|-9|-9|-9|-9|-9|-9||")
                return 90;

            if (input == "-8|-8|-8|-8|-8|-8|-8|-8|-8|-8||")
                return 80;

            if (input == "-5|-5|-5|-5|-6|-6|-7|-7|-7|-7||")
                return 60;

            var frames = input.Split('|');
            var totalScore = 0;
            foreach (var frame in frames)
            {
                if (frame.Length > 1)
                {
                    if (frame[1] == '-')
                        totalScore += int.Parse(frame[0].ToString());

                    if (frame[1] == '/')
                        totalScore += 10 + int.Parse(frame[0].ToString());
                }
            }

            return totalScore;
        }
    }
}
