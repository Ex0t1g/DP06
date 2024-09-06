using static System.Console;
namespace DP06.Expr;

public class InputExpr : IExpr
{
    public int Calculate()
    {
        int numbers;
        Int32.TryParse(ReadLine(), out numbers);
        return numbers;
    }


}
