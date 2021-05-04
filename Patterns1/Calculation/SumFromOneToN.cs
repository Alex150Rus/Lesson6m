namespace Patterns1.Calculation
{
    internal sealed class SumFromOneToN : ICalculateSumFromOneToN
    {
        public int calculateSumFromOneToN(int n)
        {
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}