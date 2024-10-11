namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            string[] delimiters = [",", "\n"];

            var numbersArray = numbers.Split(delimiters, StringSplitOptions.None);

            var sum = 0;

            foreach (var number in numbersArray)
                sum += int.Parse(number);

            return sum;
        }
    }
}
