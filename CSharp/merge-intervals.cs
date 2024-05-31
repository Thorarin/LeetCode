// https://leetcode.com/problems/merge-intervals/
// Weirdly easy for a Medium difficulty problem?!?

public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        var merged = new List<int[]>();

        foreach (var interval in intervals) {
            if (merged.Count > 0 && interval[0] <= merged[^1][1]) {
                merged[^1][1] = Math.Max(merged[^1][1], interval[1]);
            } else {
                merged.Add(interval);
            }
        }

        return merged.ToArray();
    }
}