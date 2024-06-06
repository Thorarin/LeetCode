// https://leetcode.com/problems/ransom-note/

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var noteCounts = CountLetters(ransomNote);
        var magazineCounts = CountLetters(magazine);

        for (int i = 0; i < noteCounts.Length; i++) {
            if (noteCounts[i] > magazineCounts[i]) {
                return false;
            }
        }

        return true;
    }

    private int[] CountLetters(string str) {
        var result = new int[26];
        foreach (char letter in str) {
            result[letter - 97]++;
        }
        return result;
    }
}