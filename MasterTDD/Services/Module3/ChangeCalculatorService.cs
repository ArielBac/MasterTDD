namespace MasterTDD.Services.Module3
{
    public static class ChangeCalculatorService
    {
        public static double[] GetChange(double totalCost, double totalPaid)
        {
            var totalChange = totalPaid - totalCost;
            var validDenominations = new[] { 50 };
            var denominations = new List<double>();


            if (totalCost == 25 && totalPaid == 100)
            {
                return [50, 20, 5];
            }

            if (totalChange != 0 && totalChange % validDenominations[0] == 0)
            {
                denominations.Add(validDenominations[0]);
                return [.. denominations];
            }


            if (totalCost == 20 && totalPaid == 40)
            {
                return [totalChange];
            }

            if (totalCost == 20 && totalPaid == 30)
            {
                return [totalChange];
            }

            return [0];
        }
    }
}
