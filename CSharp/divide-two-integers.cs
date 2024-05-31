// https://leetcode.com/problems/divide-two-integers/
// What an extremely annoying problem, with all the corner cases.
// I haven't found a good way to deal with the integer underflow and overflow,
// sorry for the terrible code :P
//
// 10 / 3 = 3
// 7 / -3 = -2
// 2147483647 / 2 = 1073741823
// -2147483648 / 1 = -2147483648
// -2147483648 / 2 = -1073741824
// -2147483648 / 4 = -536870912
// -2147483648 / -1 = 2147483647 (!)

public class Solution {
    public int Divide(int dividend, int divisor) {
        bool neg = false;
        bool min = false;

		// Get rid of corner cases that cause problems in the rest of the algorithm
        if (dividend == 0) return 0;
        if (divisor == 1) return dividend;
        if (dividend == divisor) return 1;
        if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

        if (dividend == int.MinValue) {
			// Effectively add abs(divisor) to dividend so it's no longer int.MinValue
			// and we can safely use the dividend's absolute value.
			// Set a flag to add one to the answer later...
            if (divisor > 0) {
                dividend = Math.Abs(dividend + divisor);
                min = true;
                neg = true;
            } else {
                dividend -= divisor;
                min = true;
            }
        }
        if (dividend == divisor) return 1;
        if (divisor == int.MinValue) return 0;

        if (dividend == int.MinValue) {
            dividend = int.MaxValue;
            if (divisor < 0) {
                divisor = -divisor;
            } else {
                neg = true;
            }
        }
        
        if (Math.Sign(dividend) != Math.Sign(divisor)) {
            neg = true;
        }

        dividend = Math.Abs(dividend);
        divisor = Math.Abs(divisor);
        
        int shifted = 1;
        int denominator = divisor;
        while (true) {
            int temp = denominator << 1;
            if (temp <= 0) break;
            if (temp > dividend) break;

            shifted <<= 1;
            denominator = temp;
        }

        int answer = 0;

        while (shifted != 0) {
            if (dividend >= denominator) {
                dividend -= denominator;
                answer |= shifted;
            }
            shifted >>= 1;
            denominator >>= 1;
        }

        if (min) answer++;

        return neg ? -answer : answer;
    }
}