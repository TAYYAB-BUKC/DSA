namespace DSA.Basics.EuclideanAlgorithm
{
    public class EuclideanAlgorithm
    {
        public static long CalculateGreatestCommonDivisor(long firstNumber, long secondNumber)
        {
            if (secondNumber == 0)
                return firstNumber;

            return CalculateGreatestCommonDivisor(secondNumber, firstNumber % secondNumber);
        }
    }
}