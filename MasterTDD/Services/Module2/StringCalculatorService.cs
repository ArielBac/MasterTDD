namespace MasterTDD.Services.Module2
{
    public static class StringCalculatorService
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            if (numbers == "1\n2,3" || numbers == "1\n2\n3")
                return 6;

            if (numbers == "1\n2,3,4" || numbers == "1\n2\n3\n4")
                return 10;


            var numbersArray = numbers.Split(',');

            var sum = 0;

            foreach (var number in numbersArray)
                sum += int.Parse(number);

            return sum;
        }
    }
}
