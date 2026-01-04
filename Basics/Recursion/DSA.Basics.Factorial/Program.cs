using DSA.Basics.Factorial;

Console.Write("Enter a number greater than or equal to zero : ");
long number = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Factorial of " + number + " is " + Factorial.CalculateFactorial(number));

Console.ReadKey();