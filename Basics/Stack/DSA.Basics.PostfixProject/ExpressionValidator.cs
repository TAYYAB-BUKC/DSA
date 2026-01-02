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
    }
}