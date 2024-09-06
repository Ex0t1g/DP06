namespace DP06.Expr;


public class ForStatement : IStatement
{
    private AssignExpr counter;
    private IExpr condition;
    private IStatement statement;
    private IExpr oper;

    public ForStatement(AssignExpr counter, IExpr condition, IExpr oper, IStatement statement)
    {
        this.counter = counter;
        this.condition = condition;
        this.statement = statement;
        this.oper = oper;
    }

    public void Execute()
    {

        counter.Calculate();
        while (condition.Calculate() != 0)
        {
            statement.Execute();
            oper.Calculate();
        }
    }
}
