namespace MasterTDD.Services
{
    public static class LeapYearService
    {
        public static bool Verify(int year)
        {
            if (year == 4 || year == 8 || year == 12)
                return true;

            return false;
        }
    }
}
