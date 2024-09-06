namespace DP06;

public class AssignExpr : IExpr {
    private VarExpr left;
    private IExpr right;

    public AssignExpr (VarExpr left, IExpr right) {
        this.left = left;
        this.right = right;
    }

    public int Calculate () =>
        VarExpr.Vars[left.Name] = right.Calculate ();
}
