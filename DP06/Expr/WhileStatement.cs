namespace DP06.Expr
{
    public class WhileStatement
    {
        private IExpr condition;
        private IStatement statement;

        public WhileStatement(IExpr condition, IStatement statement)
        {
            this.condition = condition;
            this.statement = statement;
        }

        public void Execute()
        {
            while (condition.Calculate() != 0)
                statement.Execute();
        }
    }
}
