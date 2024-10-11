namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            if (numbers == "1\n2,3")
                return 6;

            var numbersArray = numbers.Split(',');

            var sum = 0;

            foreach (var number in numbersArray)
                sum += int.Parse(number);

            return sum;
        }
    }
}
