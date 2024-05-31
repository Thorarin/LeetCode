// https://leetcode.com/problems/next-permutation/
// TODO There is a followup question to not use a string
public class Solution {
    public bool IsPalindrome(int x) {
        string number = x.ToString();
        for (int i = 0; i < number.Length / 2; i++) {
            if (number[i] != number[^(i + 1)]) return false;
        }
        return true;
    }
}