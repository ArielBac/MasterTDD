namespace MasterTDD.Services.Module1
{
    public static class LeapYearService
    {
        public static bool Verify(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
