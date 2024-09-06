namespace DP06.Expr;

public class ExprStatement : IStatement
{
    private IExpr expr;
    public ExprStatement(IExpr expr) => this.expr = expr;

    public void Execute() => expr.Calculate();
}
