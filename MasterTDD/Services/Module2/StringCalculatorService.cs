namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            var delimitersArray = GetDelimitersList(numbers);

            var numbersArray = numbers.Split(delimitersArray, StringSplitOptions.RemoveEmptyEntries);

            List<int> intNumbersList = numbersArray.ToIntNumbersList();
            List<int> negativeNumbersList = intNumbersList.GetNegativeNumbersOrDefault();

            if (negativeNumbersList.Count > 0)
                throw new Exception($"Negatives not allowed: {string.Join(",", negativeNumbersList)}");

            var sum = intNumbersList.Sum();

            return sum;
        }

        private static string[] GetDelimitersList(string numbers)
        {
            List<string> delimitersList = [",", "\n"];

            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Substring(2);
                var customDelimiter = numbers.First().ToString();
                delimitersList.Add(customDelimiter);
            }

            string[] delimitersArray = [.. delimitersList];

            return delimitersArray;
        }

        private static List<int> ToIntNumbersList(this string[] numbersArray)
        {
            List<int> intNumbersList = [];

            foreach (var number in numbersArray)
            {
                if (int.TryParse(number, out int intNumber))
                    intNumbersList.Add(intNumber);
            }

            return intNumbersList;
        }

        private static List<int> GetNegativeNumbersOrDefault(this List<int> numbersList)
        {
            List<int> negativeNumbersList = [];

            foreach (var number in numbersList)
            {
                if (int.IsNegative(number))
                    negativeNumbersList.Add(number);
            }

            return negativeNumbersList;
        }
    }
}
