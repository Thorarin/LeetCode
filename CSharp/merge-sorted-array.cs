// https://leetcode.com/problems/merge-sorted-array/

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int pos = m + n - 1;
        m--;
        n--;

        while (n >= 0) {
            if (m >= 0 && nums1[m] >= nums2[n]) {
                nums1[pos] = nums1[m];
                m--;
            } else {
                nums1[pos] = nums2[n];
                n--;
            }
            pos--;
        }
    }
}
