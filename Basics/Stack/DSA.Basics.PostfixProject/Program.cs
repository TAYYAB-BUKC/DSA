using DSA.Basics.PostfixProject;

Console.Write("Enter infix expression : ");
string infixExpression = Console.ReadLine();

if (infixExpression is null)
{
    Console.WriteLine("please enter expression.");
    return;
}

string postfixExpression = ExpressionValidator.ConvertInfixExpressionToPostfixExpression(infixExpression);

Console.WriteLine("Postfix expression is : " + postfixExpression);

Console.WriteLine("Value of expression : " + ExpressionValidator.EvaluatePostfixExpression(postfixExpression));

Console.ReadKey();