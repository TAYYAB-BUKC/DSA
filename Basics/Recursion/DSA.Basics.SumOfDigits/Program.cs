using DSA.Basics.SumOfDigits;

Console.Write("Enter a number greater than or equal to zero : ");
long number = Convert.ToInt64(Console.ReadLine());

Console.WriteLine(SumOfDigits.CalculateSumOfDigits(number));

Console.ReadKey();