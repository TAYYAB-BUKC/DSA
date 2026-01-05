using DSA.Basics.Display1toNDigits;

Console.WriteLine("Enter value of n : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Display1toNDigits.Display1toNDigitsInAscendingOrder(number);

Console.WriteLine();
Display1toNDigits.Display1toNDigitsInDescendingOrder(number);
Console.WriteLine();

Console.ReadKey();