namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            var numbersArray = numbers.Split(',');

            if (numbersArray.Length == 2)
            {
                var number1 = int.Parse(numbersArray[0]);
                var number2 = int.Parse(numbersArray[1]);

                return number1 + number2;
            }

            return int.Parse(numbers);
        }
    }
}
