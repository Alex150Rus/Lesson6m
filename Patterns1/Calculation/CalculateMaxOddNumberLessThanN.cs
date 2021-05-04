namespace Patterns1.Calculation
{
    internal sealed class CalculateMaxOddNumberLessThanN : ICalculateMaxOddNumberLessThanN 
    {
        public int CalcMaxOddNumberLessThanN(int n)
        {
            int maxOdd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i%2 == 0)
                {
                    maxOdd = i;
                }
            }

            return maxOdd;
        }
    }
}