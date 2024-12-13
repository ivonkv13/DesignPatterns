public class MinusExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public MinusExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret(Context context)
    {
        return _left.Interpret(context) - _right.Interpret(context);
    }
}
