namespace Algorithms.LengthOfLongestSubstring;

public class LengthOfLongestSubstring
{
    /// <summary>
    /// Algorithm : Sliding Window
    ///  Efficiency : O(n)
    /// 	1.	counter از اول تا آخر فقط یک بار جلو می‌رود
    ///     2.	left هم فقط جلو می‌رود و هیچ‌وقت عقب نمی‌آید
    /// </summary>
    public int Calculate(string s)
    {
        var lastIndex = new Dictionary<char, int>();

        int left = 0;   // شروع پنجره
        int best = 0;   // بهترین طول تا اینجا

        for (int counter = 0; counter < s.Length; counter++)
        {
            char c = s[counter];    

            // اگر قبلاً این حرف را دیده‌ایم
            if (lastIndex.TryGetValue(c, out int prevIndex))
            {
                // اگر آن قبلی داخل پنجره فعلی است، left را جلو می‌بریم
                if (prevIndex >= left)
                    left = prevIndex + 1;
            }

            // آخرین محل این حرف را به‌روزرسانی می‌کنیم
            lastIndex[c] = counter;

            // طول پنجره فعلی
            int len = counter - left + 1;
            if (len > best) best = len;
        }

        return best;
    }
}