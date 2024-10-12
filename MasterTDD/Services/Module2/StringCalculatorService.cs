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

            List<int> intNumberList = [];
            List<int> negativeNumberList = [];

            foreach (var number in numbersArray)
            {
                var intNumber = int.Parse(number);

                if (int.IsNegative(intNumber))
                    negativeNumberList.Add(intNumber);

                intNumberList.Add(intNumber);
            }

            if (negativeNumberList.Count > 0)
                throw new Exception();

            var sum = intNumberList.Sum();

            return sum;
        }
    }
}
