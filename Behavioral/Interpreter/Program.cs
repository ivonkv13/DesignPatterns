namespace Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defines a representation for a language and interprets sentences in that language.

            //Real-life analogy:
            //A "calculator" interprets mathematical expressions.

            Context context = new Context();

            string expression = "5 + 10 - 3";
            IExpression parsedExpression = ExpressionParser.Parse(expression);
            int result = parsedExpression.Interpret(context);

            Console.WriteLine($"The result of '{expression}' is: {result}");
            // Output: The result of '5 + 10 - 3' is: 12
        }
    }
}
