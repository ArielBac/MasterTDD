namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            var numbersArray = numbers.Split(',');

            if (numbersArray.Length >= 2)
            {
                var sum = 0;

                foreach (var number in numbersArray)
                    sum += int.Parse(number);

                return sum;
            }

            return int.Parse(numbers);
        }
    }
}
