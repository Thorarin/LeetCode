// https://leetcode.com/problems/next-permutation/
public class Solution {
    public void NextPermutation(int[] nums) {
        int swapped = Swap(nums);
        Array.Sort(nums, swapped + 1, nums.Length - swapped - 1);
    }

    private int Swap(int[] nums) {
        for (int i = nums.Length - 2; i >= 0; i--) {
            for (int j = nums.Length - 1; j > i; j--) {
                if (nums[j] > nums[i]) {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    return i;
                }
            }
        }

        return -1;
    }
}