namespace MasterTDD.Services.Module3
{
    public static class ChangeCalculatorService
    {
        public static double[] GetChange(double totalCost, double totalPaid)
        {
            var totalChange = totalPaid - totalCost;
            var validDenominations = new[] { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            var denominations = new List<double>() { };


            for (var i = 0; i < validDenominations.Length; i++)
            {
                if (Math.Round(totalChange / validDenominations[i], 2, MidpointRounding.AwayFromZero) >= 1)
                {
                    denominations.Add(validDenominations[i]);
                    totalChange -= validDenominations[i];
                    i--;
                }
            }

            var sortedDenominations = denominations.OrderByDescending(x => x);
            return [.. sortedDenominations];
        }
    }
}
