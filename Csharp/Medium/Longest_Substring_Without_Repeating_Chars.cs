namespace Csharp;

// Given a string s, find the length of the longest substring without repeating characters.

// Example 1:
//
// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.

public static partial class LeetCodeChallenge
{
    public static int LengthOfLongestSubstring(string s)
    {
        // sliding window algorithm
        var dic = new Dictionary<char, int>();
        var right = 0;
        var left = 0;
        var max = 0;

        while (right < s.Length)
        {
            if (!dic.ContainsKey(s[right]))
            {
                max = Math.Max(max, right - left + 1);
            }
            else
            {
                if (dic[s[right]] < left)
                    max = Math.Max(max, right - left + 1);
                else
                    left = dic[s[right]] + 1;
            }

            dic[s[right]] = right;
            right++;
        }

        return max;
    }
}
