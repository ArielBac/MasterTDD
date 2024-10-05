namespace MasterTDD.Services.Module1
{
    public static class FibonacciService
    {
        public static int GetNumberAtPosition(int position)
        {
            if (position < 2)
                return position;

            return GetNumberAtPosition(position - 2) + GetNumberAtPosition(position - 1);
        }
    }
}
