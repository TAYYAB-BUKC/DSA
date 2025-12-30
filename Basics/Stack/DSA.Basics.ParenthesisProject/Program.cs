using DSA.Basics.ParenthesisProject;

string? expression;

Console.Write("Enter an expression with parenthesis : ");
expression = Console.ReadLine();

if(!string.IsNullOrWhiteSpace(expression))
{
	if (ParenthesisValidator.IsValid(expression))
		Console.WriteLine("Valid expression");
	else
		Console.WriteLine("Invalid expression");
}
else
{
	Console.WriteLine("Expression is not valid");
}