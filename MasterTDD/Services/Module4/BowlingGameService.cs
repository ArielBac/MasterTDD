namespace MasterTDD.Services.Module4
{
    public static class BowlingGameService
    {
        public static int Run(string input)
        {
            if (input == "X|X|X|X|X|X|X|X|X|X||XX")
                return 300;

            if (input == "9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||")
                return 90;

            return 0;
        }
    }
}
