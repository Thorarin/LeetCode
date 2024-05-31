// https://leetcode.com/problems/remove-element/
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            if (nums[i] == val) {
                nums[i] = nums[k];
                k--;
            }
        }
        return k + 1;
    }
}