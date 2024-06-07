// https://leetcode.com/problems/first-unique-character-in-a-string/
// It's not pretty with this magic value stuff, but it performs well.
public class Solution {
    public int FirstUniqChar(string s) {
        var letters = new int[26];
        Array.Fill(letters, int.MaxValue);

        for (int p = 0; p < s.Length; p++) {
            int index = s[p] - 97;
            if (letters[index] == int.MaxValue) {
                letters[index] = p;
            } else {
                letters[index] = int.MaxValue - 1;
            }
        }

        int result = letters.Min();
        return result >= int.MaxValue - 1 ? -1 : result;
    }
}