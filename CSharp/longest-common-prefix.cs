// https://leetcode.com/problems/longest-common-prefix/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var prefix = strs[0].AsSpan();
        for (int i = 1; i < strs.Length; i++) {
            var str = strs[i].AsSpan();
            while (!str.StartsWith(prefix)) {
                if (prefix.Length == 0) return "";
                prefix = prefix[0..^1];
            }
        }

        return prefix.ToString();
    }
}