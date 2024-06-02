// https://leetcode.com/problems/subsets/
//
// This is actually the second version of my solution.
// Initially I wrote it will all inlined functions instead of an iterator,
// which saved me from creating new arrays for every next iteration.
// This version is a little easier to read, though. Also, by filling in
// the actual values from nums into the same array in TransformSet
// no more allocation is done than necessary.
// 
// I still ended up with a local function to avoid using a goto statement to
// break out of a nested loop.

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();

        foreach (var set in IteratePowerset(nums.Length)) {
            TransformSet(set);
            result.Add(set);
        }
        
        return result;

        void TransformSet(int[] set) {
            for (int i = 0; i < set.Length; i++) {
                set[i] = nums[set[i]];
            }
        }
    }
    
    IEnumerable<int[]> IteratePowerset(int size) {
        // Create an array indicating which element numbers we select for our set
        // It's created one element longer than apparently necessary to remove
        // the need for bounds checking later in the iteration algorithm.
        int max = size - 1;
        var selected = new int[size + 1];
        for (int i = 0; i < selected.Length; i++) {
            selected[i] = size;
        }
        
        int setSize = 0;
        
        while (true) {
            // Print();
            yield return selected[0..setSize];

            if (!TryIterate()) {
                // Exhausted permutations with current set size.
                if (setSize == size) break;
                setSize++;

                for (int j = 0; j < setSize; j++) {
                    selected[j] = j;
                }
            }
        }

        bool TryIterate() {
            for (int i = setSize - 1; i >= 0; i--) {
                if (selected[i] < selected[i + 1] - 1) {
                    selected[i]++;
                    for (int j = i + 1; j < setSize; j++) {
                        if (selected[j] > max) break;
                        selected[j] = selected[j - 1] + 1;
                    }

                    return true;
                }
            }

            return false;
        }        

        void Print() {
            Console.WriteLine($"[{string.Join(", ", selected[0..setSize])}]"); 
        }        
    }
}