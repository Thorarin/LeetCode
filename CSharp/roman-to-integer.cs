public class Solution {
    public int RomanToInt(string s) {
        var counts = new int[7];
        foreach (char c in s) {
            int index = NumeralIndex(c);
            counts[index]++;
            if (index >= 1 && counts[index - 1] != 0) {
				// 
                counts[index - 1] = -1;
            }
            if (index >= 2 && counts[index - 2] != 0) {
                counts[index - 2] = -1;
            }            
        }

        return counts[6] * 1000 + counts[5] * 500 + counts[4] * 100 + counts[3] * 50 + counts[2] * 10 + counts[1] * 5 + counts[0];
    }

    private static int NumeralIndex(char c) {
        return c switch {
            'I' => 0,
            'V' => 1,
            'X' => 2,
            'L' => 3,
            'C' => 4,
            'D' => 5,
            'M' => 6
        };
    }
}