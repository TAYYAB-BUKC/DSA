namespace DSA.Basics.Exponentiation
{
    public class Exponentiation
    {
        public static double Power(double baseValue, int number)
        {
            if (number == 0)
                return 1;

            return baseValue * Power(baseValue, number - 1);
        }
    }
}