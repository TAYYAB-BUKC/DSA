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
    }
}
