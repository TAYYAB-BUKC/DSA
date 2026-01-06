using DSA.Basics.BaseConversion;

Console.Write("Enter a positive decimal number : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Binary form : "); BaseConversion.ConvertBaseToBinary(number);
Console.WriteLine();
Console.Write("Binary form : "); BaseConversion.ConvertBase(number, 2);
Console.WriteLine();
Console.Write("Octal form : "); BaseConversion.ConvertBase(number, 8);
Console.WriteLine();
Console.Write("Hexadecimal form : "); BaseConversion.ConvertBase(number, 16);
Console.WriteLine();