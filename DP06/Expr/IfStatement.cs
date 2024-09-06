namespace DP06.Expr;

public class IfStatement : IStatement
{
    private IExpr condition;
    private IStatement then;

    public IfStatement(IExpr condition, IStatement then)
    {
        this.condition = condition;
        this.then = then;
    }

    public void Execute()
    {
        if (condition.Calculate() != 0)
            then.Execute();
    }
}
