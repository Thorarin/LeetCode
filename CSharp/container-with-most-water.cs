// https://leetcode.com/problems/container-with-most-water/
// TODO Runtime needs improvement!
// [1,8,6,2,5,4,8,3,7] = 49
// [1,1] = 1
// [2,3,4,5,18,17,6] = 17
// [5,2,12,1,5,3,4,11,9,4] = 55

public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;

        for (int left = 0; left < height.Length - 1; left++) {
            int h = height[left];
            if (h == 0) continue;
           
            int neededWidth = maxArea / h;
            //if (left == 4) Console.WriteLine($"joe {neededWidth} {h}");
            var (mh, mr, ma) = FindMaximum(height, left, neededWidth);
            if (ma > maxArea) {
                //Console.WriteLine($"{left} {mr} {ma}");
                maxArea = ma;
            }
        }

        return maxArea;
    }

    (int height, int right, int area) FindMaximum(int[] height, int left, int neededWidth) {
        int leftHeight = height[left];
        int bestHeight = 0;
        int bestArea = 0;
        int bestRight = -1;
        int bestHeightDiff = leftHeight;

        for (int right = height.Length - 1; right >= left + neededWidth; right--) {
            int rightHeight = height[right];
            int h = Math.Min(leftHeight, rightHeight);
            int area = h * (right - left);
            //if (left == 4) Console.WriteLine($"hoe {right} {h} {area}");            
            if (area > bestArea) {
                bestHeight = h;
                bestArea = area;
                bestRight = right;
                bestHeightDiff = Math.Abs(leftHeight - rightHeight);
                //if (left == 2) Console.WriteLine($"boe {leftHeight} {rightHeight} - {bestHeightDiff} {bestHeight}");            
                if ((bestHeightDiff * (right - left)) < bestHeight) break;
            }
        }

        return (bestHeight, bestRight, bestArea);
    }

    // int CalculateArea(int[] height, int left, int right) {
    //     int h = Math.Min(height)
    //     return h * (right - left);
    // }
}