namespace MasterTDD.Services
{
    public static class LeapYearService
    {
        public static bool Verify(int year)
        {
            if (year == 400 || year == 500 || year == 600)
                return false;

            if (year % 4 == 0)
                return true;

            return false;
        }
    }
}
