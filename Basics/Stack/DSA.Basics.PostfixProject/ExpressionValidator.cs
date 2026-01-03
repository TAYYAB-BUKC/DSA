namespace DSA.Basics.PostfixProject
{
    public class ExpressionValidator
    {
        public static int PrecedenceChecker(char symbol)
        {
            switch (symbol)
            {
                case '(':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                case '%':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        public static int EvaluatePower(int baseValue, int exponent)
        {
            if (exponent < 0)
                throw new ArgumentException("Exponent must be non-negative");

            if (exponent == 0)
                return 1;

            int index, power = 1;
            for (index = 1; index <= exponent; index++)
                power *= baseValue;
            return power;
        }

        public static String ConvertInfixExpressionToPostfixExpression(string infixExpression)
        {
            string postfix = "";

            CharacterStackUsingArray stack = new(infixExpression.Length);

            char next, symbol;

            for (int index = 0; index < infixExpression.Length; index++)
            {
                symbol = infixExpression[index];

                if (symbol == ' ' || symbol == '\t') /*ignore blanks and tabs*/
                    continue;

                switch (symbol)
                {
                    case '(':
                        stack.Push(symbol);
                        break;
                    case ')':
                        while ((next = (char)stack.Pop()) != '(')
                            postfix = postfix + next;
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '%':
                    case '^':
                        while (!stack.IsEmpty() && PrecedenceChecker((char)stack.Peek()) >= PrecedenceChecker(symbol))
                            postfix = postfix + stack.Pop();
                        stack.Push(symbol);
                        break;
                    default: /*operand*/
                        postfix = postfix + symbol;
                        break;
                }
            }
            while (!stack.IsEmpty())
                postfix = postfix + stack.Pop();
            return postfix;
        }
    }
}