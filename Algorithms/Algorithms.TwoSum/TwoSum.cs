namespace Algorithms.TwoSum;

public class TwoSum
{
    public int[] Calculate(int[] numbers, int target)
    {
        // value -> index
        var seen = new Dictionary<int, int>(numbers.Length);

        for (int i = 0; i < numbers.Length; i++)
        {
            int x = numbers[i];
            int needed = target - x;

            if (seen.TryGetValue(needed, out int j))
            {
                return new[] { j, i };
            }

            // اگر تکراری باشد، معمولاً نگه داشتن اولین اندیس کافی است
            // چون اولین برخورد، زودتر جواب می‌دهد
            if (!seen.ContainsKey(x))
                seen[x] = i;
        }

        // اگر جواب وجود نداشت
        return Array.Empty<int>();
    }
}