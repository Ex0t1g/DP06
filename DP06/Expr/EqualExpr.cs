using static System.Console;

namespace DP06.Expr;

public class EqualExpr : BinaryExpr
{
    public EqualExpr(IExpr left, IExpr right) : base(left, right) { }

    public override int Calculate() => left.Calculate() == right.Calculate() ? 1 : 0; 

}
