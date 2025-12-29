namespace DSA.Basics.ParenthesisProject
{
	public class ParenthesisValidator
	{
		static bool AreParenthesisMatch(char leftParenthesis, char rightParenthesis)
		{
			if (leftParenthesis == '[' && rightParenthesis == ']')
				return true;
			if (leftParenthesis == '{' && rightParenthesis == '}')
				return true;
			if (leftParenthesis == '(' && rightParenthesis == ')')
				return true;
			return false;
		}
	}
}