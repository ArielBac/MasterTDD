﻿namespace MasterTDD.Services.Module1
{
    public static class FibonacciService
    {
        public static int GetNumberAtPosition(int position)
        {
            if (position == 2 || position == 3)
                return 1;

            return 0;
        }
    }
}
