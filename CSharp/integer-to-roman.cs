// https://leetcode.com/problems/integer-to-roman/

public class Solution {
    public string IntToRoman(int num) {
        StringBuilder sb = new ();

        while (num > 0) {
            switch (num) {
                case >= 1000:
                    sb.Append('M');
                    num -= 1000;
                    break;
                case >= 900:
                case >= 400 and < 500:
                    sb.Append('C');
                    num += 100;
                    break;
                case >= 500:
                    sb.Append('D');
                    num -= 500;
                    break;
                case >= 100:
                    sb.Append('C');
                    num -= 100;
                    break;
                case >= 90 and < 100:
                    sb.Append('X');
                    num += 10;
                    break;
                case >= 50:
                    sb.Append('L');
                    num -= 50;
                    break;
                case >= 40 and < 50:
                    sb.Append('X');
                    num += 10;
                    break;
                case >= 10:
                    sb.Append('X');
                    num -= 10;
                    break;
                case 9:
                case 4:
                    sb.Append('I');
                    num += 1;
                    break;
                case >= 5:
                    sb.Append('V');
                    num -= 5;
                    break;
                default:
                    sb.Append('I');
                    num -= 1;
                    break;
            }
        }

        return sb.ToString();
    }
}