namespace DSA.Basics.ParenthesisProject
{
	public class ParenthesisValidator
	{
		public static bool AreParenthesisMatch(char leftParenthesis, char rightParenthesis)
		{
			if (leftParenthesis == '[' && rightParenthesis == ']')
				return true;
			if (leftParenthesis == '{' && rightParenthesis == '}')
				return true;
			if (leftParenthesis == '(' && rightParenthesis == ')')
				return true;
			return false;
		}

		public static bool IsValid(string expression)
		{
			StackUsingArray stack = new();

			char? character;

			for (int i = 0; i < expression.Length; i++)
			{
				if (expression[i] == '(' || expression[i] == '{' || expression[i] == '[')
					stack.Push(expression[i]);

				if (expression[i] == ')' || expression[i] == '}' || expression[i] == ']')
					if (stack.IsEmpty())
					{
						Console.WriteLine("Right parentheses are more than left parentheses");
						return false;
					}
					else
					{
						character = stack.Pop();
						if (character.HasValue)
						{
							if (!AreParenthesisMatch(character.Value, expression[i]))
							{
								Console.WriteLine("Mismatched parentheses are : ");
								Console.WriteLine(character + " and " + expression[i]);
								return false;
							}
						}
					}
			}

			if (stack.IsEmpty())
			{
				Console.WriteLine("Balanced Parentheses");
				return true;
			}
			else
			{
				Console.WriteLine("Left parentheses are more than right parentheses");
				return false;
			}
		}
	}
}