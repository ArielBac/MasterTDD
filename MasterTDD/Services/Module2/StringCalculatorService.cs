namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            List<string> delimiters = [",", "\n"];

            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Substring(2);
                var customDelimiter = numbers.First().ToString();
                delimiters.Add(customDelimiter);
            }

            string[] delimiterArray = [.. delimiters];

            var numbersArray = numbers.Split(delimiterArray, StringSplitOptions.RemoveEmptyEntries);

            var sum = 0;

            foreach (var number in numbersArray)
                sum += int.Parse(number);

            return sum;
        }
    }
}
