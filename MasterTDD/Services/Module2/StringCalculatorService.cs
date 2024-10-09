namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            var numbersArray = numbers.Split(',');

            var sum = 0;

            foreach (var number in numbersArray)
                sum += int.Parse(number);

            return sum;
        }
    }
}
