

namespace DP06.Expr
{
    public class LessExpr : BinaryExpr
    {
        public LessExpr(IExpr left, IExpr right) : base(left, right) { }

        public override int Calculate() => left.Calculate() < right.Calculate() ? 1 : 0;
    }
}
