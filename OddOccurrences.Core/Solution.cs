namespace OddOccurrences.Core
{
    public class Solution
    {
        public int OddOccurrence(int[] a)
        {
            var result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result = result ^ a[i]; //XOR
            }
            return result;
        }
    }
}
