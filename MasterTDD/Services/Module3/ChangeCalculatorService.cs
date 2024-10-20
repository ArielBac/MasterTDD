namespace MasterTDD.Services.Module3
{
    public static class ChangeCalculatorService
    {
        public static double[] GetChange(double totalCost, double totalPaid)
        {
            var totalChange = totalPaid - totalCost;
            var validDenominations = new[] { 100, 50, 20, 10, 5, 1 };
            var denominations = new List<double>() { };


            foreach (var denomination in validDenominations)
            {
                if (totalChange / denomination >= 1)
                {
                    denominations.Add(denomination);
                    totalChange -= denomination;
                }
            }

            var sortedDenominations = denominations.OrderByDescending(x => x);
            return [.. sortedDenominations];
        }
    }
}
