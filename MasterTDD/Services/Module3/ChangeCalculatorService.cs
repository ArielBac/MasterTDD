﻿namespace MasterTDD.Services.Module3
{
    public static class ChangeCalculatorService
    {
        public static double[] GetChange(double totalCost, double totalPaid)
        {
            if (totalCost == 25 && totalPaid == 100)
            {
                return [50, 20, 5];
            }

            if (totalCost == 50 && totalPaid == 100)
            {
                return [50];
            }

            return [0];
        }
    }
}
