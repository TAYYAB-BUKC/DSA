using DSA.Basics.Exponentiation;

Console.Write("Enter values for number and baseValue : ");

double number = Convert.ToDouble(Console.ReadLine());

int baseValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number + "^" + baseValue + "=" + Exponentiation.Power(number, baseValue));