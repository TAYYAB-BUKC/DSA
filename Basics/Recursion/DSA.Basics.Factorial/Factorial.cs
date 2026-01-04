namespace DSA.Basics.Factorial
{
    public class Factorial
    {
        public static long CalculateFactorial(long number)
        {
            if (number == 1)
                return 1;

            return number * CalculateFactorial(number - 1);
        }
    }
}