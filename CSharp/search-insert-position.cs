// https://leetcode.com/problems/search-insert-position/
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int index = Array.BinarySearch(nums, target);
        return index < 0 ? ~index : index;
    }
}