﻿namespace DP06.Expr;

public class BlockStatement : IStatement
{
    private IReadOnlyList<IStatement> statements;
    public BlockStatement(params IStatement[] statements)
    {
        this.statements = statements;
    }

    public void Execute()
    {
        foreach (IStatement statement in statements)
            statement.Execute();
    }
}
