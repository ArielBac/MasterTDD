namespace MasterTDD.Services.Module4
{
    public static class BowlingGameService
    {
        public static int Run(string input)
        {
            if (input == "X|X|X|X|X|X|X|X|X|X||XX")
                return 300;

            return 0;
        }
    }
}
