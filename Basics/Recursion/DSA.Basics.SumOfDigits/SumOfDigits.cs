namespace DSA.Basics.SumOfDigits
{
    public class SumOfDigits
    {
        public static int CalculateSumOfDigits(int number)
        {
            if (number / 10 == 0)
                return number;

            return CalculateSumOfDigits(number / 10) + number % 10;
        }
    }
}