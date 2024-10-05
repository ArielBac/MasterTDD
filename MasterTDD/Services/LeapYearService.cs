namespace MasterTDD.Services
{
    public static class LeapYearService
    {
        public static bool Verify(int year)
        {
            if (year % 4 == 0)
                return true;

            return false;
        }
    }
}
