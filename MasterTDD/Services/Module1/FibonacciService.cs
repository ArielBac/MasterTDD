namespace MasterTDD.Services.Module1
{
    public static class FibonacciService
    {
        public static int GetNumberAtPosition(int position)
        {
            if (position < 2)
                return position;

            int aux1 = 1;
            int aux2 = 1;
            int fibonacciNumber = 1;

            for (int i = 2; i < position; i++)
            {
                fibonacciNumber = aux1 + aux2;

                if (i == position - 2)
                    aux1 = fibonacciNumber;

                if (i == position - 1)
                    aux2 = fibonacciNumber;
            }

            return fibonacciNumber;
        }
    }
}
