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

        public static void ConvertBase(int number, int baseValue)
        {
            if (number == 0)
                return;
            
            ConvertBase(number / baseValue, baseValue);
            
            int remainder = number % baseValue;

            if (remainder < 10)
                Console.Write(remainder);
            else
                Console.Write((char)(remainder - 10 + 'A'));
        }
    }
}