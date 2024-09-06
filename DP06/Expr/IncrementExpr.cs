

namespace DP06.Expr;
public class IncrementExpr : IExpr
{
    private VarExpr operand;

    public IncrementExpr(VarExpr operand)
    {
        this.operand = operand;
    }

    public int Calculate() => VarExpr.Vars[operand.Name]++;
}
