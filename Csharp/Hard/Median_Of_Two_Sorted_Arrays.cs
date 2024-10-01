namespace Csharp;

// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
// The overall run time complexity should be O(log (m+n)).

// Example 1:
//
// Input: nums1 = [1,3], nums2 = [2]
// Output: 2.00000
// Explanation: merged array = [1,2,3] and median is 2.

public static partial class LeetCodeChallenge
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var total = nums1.Length + nums2.Length;
        int i = 0, j = 0;
        var index = 0;
        var res = new int[total];

        while (i < nums1.Length || j < nums2.Length)
        {
            if (i >= nums1.Length)
            {
                res[index++] = nums2[j];
                j++;
                continue;
            }

            if (j >= nums2.Length)
            {
                res[index++] = nums1[i];
                i++;
                continue;
            }

            if (nums1[i] <= nums2[j])
            {
                res[index++] = nums1[i];
                i++;
            }
            else
            {
                res[index++] = nums2[j];
                j++;
            }
        }

        if (total % 2 == 1)
            return res[total / 2];

        var mid = total / 2;

        return (double)(res[mid] + res[mid - 1]) / 2;
    }
}
