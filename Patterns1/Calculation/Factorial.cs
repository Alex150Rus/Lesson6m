namespace Patterns1.Calculation
{
    internal sealed class Factorial : ICalculateFactorial
    {
        public int CalculateFactorial(int n)
        {
            var factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}