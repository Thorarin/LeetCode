// https://leetcode.com/problems/plus-one/

public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] == 9) continue;
            digits[i]++;
            Array.Clear(digits, i + 1, digits.Length - i - 1);
            return digits;
        }

        // Need to add a digit (all the rest will be zeroes)
        var result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}