// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
// TODO Improve runtime, it's worse than average

public class Solution {
    public int MaxProfit(int[] prices) {
        List<(int, int)> highs = new();
        List<(int, int)> lows = new();

        int length = prices.Length;

        lows.Add((prices[0], 0));
        highs.Add((prices[^1], length - 1));

        for (int i = 1; i < length - 1; i++) {
            int left = prices[i];
            int right = prices[length - i - 1];

            if (left < lows[^1].Item1) {
                lows.Add((left, i));
            }

            if (right > highs[^1].Item1) {
                highs.Add((right, length - i - 1));
            }
        }

        int best = 0;

        for (int l = lows.Count - 1; l >= 0; l--) {
            for (int h = highs.Count - 1; h >= 0; h--) {
                if (lows[l].Item2 >= highs[h].Item2) continue;
                best = Math.Max(best, highs[h].Item1 - lows[l].Item1);
            }
        }

        return best;
    }
}