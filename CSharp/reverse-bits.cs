// https://leetcode.com/problems/reverse-bits/
public class Solution {
    public uint reverseBits(uint n) {
        n = n << 16 | n >> 16;
        n = (n & 0xFF00FF00) >> 8 | (n & 0x00FF00FF) << 8; 
        n = (n & 0xF0F0F0F0) >> 4 | (n & 0x0F0F0F0F) << 4; // 1111, 0000
        n = (n & 0xCCCCCCCC) >> 2 | (n & 0x33333333) << 2; // 1100, 0011
        n = (n & 0xAAAAAAAA) >> 1 | (n & 0x55555555) << 1; // 1010, 0101
        return n;
    }
}