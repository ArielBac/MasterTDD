namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            if (numbers == "0,1")
                return 1;

            return int.Parse(numbers);
        }
    }
}
