// https://leetcode.com/problems/sqrtx/

public class Solution {
    public int MySqrt(int x) {
        if (x is 0 or 1) return x;

        int start = 1;
        int end = x;

        while (start <= end) {
            int mid = start + (end - start) / 2;
            long cmp = ((long)mid * mid) - x;
            if (cmp > 0) {
                end = mid - 1;
            } else if (cmp == 0) {
                return mid;
            } else {
                start = mid + 1;
            }
        }

        return end;
    }
}
