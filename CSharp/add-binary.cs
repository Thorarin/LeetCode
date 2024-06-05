// https://leetcode.com/problems/add-binary/

public class Solution {
    public string AddBinary(string a, string b) {
        var bits = new BitArray(Math.Max(a.Length, b.Length) + 2);

        Add(a);
        Add(b);

        var sb = new StringBuilder(bits.Count);
        for (int i = 0; i < bits.Count; i++) {
            // Skip leading zeroes
            if (sb.Length == 0 && !bits[i]) continue;
            sb.Append(bits[i] ? '1' : '0');
        }

        // Make sure there is always output, even if total is 0.
        if (sb.Length == 0) sb.Append('0');

        return sb.ToString();

        void Add(string number) {
            int j = bits.Count;
            for (int i = number.Length - 1; i >= 0; i--) {
                j--;

                if (number[i] == '1') {
                    for (int k = j; k >= 0; k--) {
                        if (!bits[k]) {
                            bits[k] = true;
                            break;
                        }
                        bits[k] = false;
                    }
                }
            }
        }
    }
}