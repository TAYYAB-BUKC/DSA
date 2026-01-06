namespace DSA.Basics.BaseConversion
{
    public class BaseConversion
    {
        public static void ConvertBaseToBinary(int number)
        {
            if (number == 0)
                return;

            ConvertBaseToBinary(number / 2);
            Console.Write(number % 2);
        }
    }
}