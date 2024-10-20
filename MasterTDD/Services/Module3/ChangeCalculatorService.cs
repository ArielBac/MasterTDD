namespace MasterTDD.Services.Module3
{
    public static class ChangeCalculatorService
    {
        public static double[] GetChange(double totalCost, double totalPaid)
        {
            var validDenominations = new[] { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            var totalChange = totalPaid - totalCost;
            var denominations = new List<double>() { };

            for (var i = 0; i < validDenominations.Length; i++)
            {
                var division = Math.Round(totalChange / validDenominations[i], 3, MidpointRounding.ToPositiveInfinity);
                if (division >= 1)
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
