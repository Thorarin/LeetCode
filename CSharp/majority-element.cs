// https://leetcode.com/problems/majority-element/
// I looked up Moore's voting algorithm as I couldn't quickly come
// up with an O(1) memory solution as requested ¯\_(ツ)_/¯
public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = 0;
        int count = 0;

        foreach (var n in nums) {
            if (count == 0) {
                candidate = n;
            }

            if (n == candidate) {
                count++;
            } else {
                count--;
            }
        }

        return candidate;
    }
}
