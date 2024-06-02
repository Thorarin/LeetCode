// https://leetcode.com/problems/length-of-last-word/
// Put in a little effort to avoid string allocation by trimming.
// Runtime: Beats 96.59% of users with C#
// Memory: Beats 91.66% of users with C#

public class Solution {
    public int LengthOfLastWord(string s) {
        int c = s.Length;
       
        while (c > 0) {
            int f = s.LastIndexOf(' ', c - 1, c);
            int length = c - f - 1;
            if (length > 0) return length;
            c--;
        }
        
        return 0;
    }
}
