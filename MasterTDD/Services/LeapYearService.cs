namespace MasterTDD.Services
{
    public static class LeapYearService
    {
        public static bool Verify(int year)
        {
            if (year == 400 || year == 800 || year == 1200)
                return true;

            if (year % 4 == 0 && year % 100 != 0)
                return true;

            return false;
        }
    }
}
