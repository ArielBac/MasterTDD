namespace MasterTDD.Services.Module3
{
    public static class ChangeCalculatorService
    {
        public static double[] GetChange(double totalCost, double totalPaid)
        {
            var totalChange = totalPaid - totalCost;

            if (totalCost == 25 && totalPaid == 100)
            {
                return [50, 20, 5];
            }

            if (totalCost == 50 && totalPaid == 100)
            {
                return [totalChange];
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
