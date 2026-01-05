using DSA.Basics.SumOfDigits;

Console.Write("Enter a number greater than or equal to zero : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigits.CalculateSumOfDigits(number));

Console.ReadKey();