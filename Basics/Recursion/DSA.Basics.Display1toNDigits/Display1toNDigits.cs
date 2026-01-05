namespace DSA.Basics.Display1toNDigits
{
    public class Display1toNDigits
    {
        public static void Display1toNDigitsInAscendingOrder(int number)
        {
            if (number == 0)
                return;

            Display1toNDigitsInAscendingOrder(number - 1);
            Console.Write(number + " ");
        }

        public static void Display1toNDigitsInDescendingOrder(int number)
        {
            if (number == 0)
                return;

            Console.Write(number + " ");
            Display1toNDigitsInDescendingOrder(number - 1);
        }
    }
}
