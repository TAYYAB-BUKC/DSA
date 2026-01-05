namespace DSA.Basics.SumOfDigits
{
    public class SumOfDigits
    {
        public static long CalculateSumOfDigits(long number)
        {
            if (number / 10 == 0)
                return number;

            return CalculateSumOfDigits(number / 10) + number % 10;
        }
    }
}