using DSA.Basics.EuclideanAlgorithm;

Console.Write("Enter values for firstNumber and secondNumber : ");
long firstNumber = Convert.ToInt64(Console.ReadLine());
long secondNumber = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Greatest Common Divisor of " + firstNumber + " and " + secondNumber + " is " + EuclideanAlgorithm.CalculateGreatestCommonDivisor(firstNumber, secondNumber));