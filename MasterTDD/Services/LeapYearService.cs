namespace MasterTDD.Services
{
    public static class LeapYearService
    {
        public static bool Verify(int year)
        {
            if (year % 4 == 0 && year % 100 != 0)
                return true;

            return false;
        }
    }
}
