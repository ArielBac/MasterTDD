namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == "0")
                return 0;

            if (numbers == "1")
                return 1;

            if (numbers == "2")
                return 2;

            return 0;
        }
    }
}
