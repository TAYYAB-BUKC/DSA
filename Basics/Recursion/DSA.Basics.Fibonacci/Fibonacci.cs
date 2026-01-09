namespace DSA.Basics.Fibonacci
{
    public class Fibonacci
    {
        public static int CalculateFibonacciSeries(int number)
        {
            if (number == 0)
                return 0;

            if (number == 1)
                return 1;

            return CalculateFibonacciSeries(number - 1) + CalculateFibonacciSeries(number - 2);
        }
    }
}