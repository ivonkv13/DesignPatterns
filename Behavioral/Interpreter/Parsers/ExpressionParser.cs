public static class ExpressionParser
{
    public static IExpression Parse(string expression)
    {
        // Example input: "5 + 10 - 3"
        var tokens = expression.Split(' ');
        // We'll use a simple left-to-right parse since it's a straightforward expression:
        // 1. Start from the left
        // 2. Convert to expression
        // 3. When we see + or -, create the appropriate expression node.

        IExpression current = new NumberExpression(int.Parse(tokens[0]));

        for (int i = 1; i < tokens.Length; i += 2)
        {
            string op = tokens[i];
            int number = int.Parse(tokens[i + 1]);

            IExpression right = new NumberExpression(number);

            if (op == "+")
                current = new PlusExpression(current, right);
            else if (op == "-")
                current = new MinusExpression(current, right);
        }

        return current;
    }
}
