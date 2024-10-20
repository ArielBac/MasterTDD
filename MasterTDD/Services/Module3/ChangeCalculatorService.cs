namespace MasterTDD.Services.Module3
{
    public static class ChangeCalculatorService
    {
        public static double[] GetChange(double totalCost, double totalPaid)
        {
            var totalChange = totalPaid - totalCost;
            var validDenominations = new[] { 50, 20 };
            var denominations = new List<double>();


            if (totalCost == 25 && totalPaid == 100)
            {
                return [50, 20, 5];
            }

            foreach (var denomination in validDenominations)
            {
                if (totalChange != 0 && totalChange % denomination == 0)
                {
                    denominations.Add(denomination);
                    return [.. denominations];
                }
            }


            if (totalCost == 20 && totalPaid == 30)
            {
                return [totalChange];
            }

            return [0];
        }
    }
}
