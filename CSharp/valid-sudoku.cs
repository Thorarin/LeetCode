// https://leetcode.com/problems/valid-sudoku/
// TODO Not entirely unexpected given the approach, but it's a little on the slow side.
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        return
            !Horizontals(board)
            .Concat(Verticals(board))
            .Concat(Boxes(board))
            .Any(HasDuplicates);
    }

    IEnumerable<IEnumerable<char>> Horizontals(char[][] board) {
        for (int v = 0; v < 9; v++) {
            yield return board[v];
        }
    }

    IEnumerable<IEnumerable<char>> Verticals(char[][] board) {
        var vertical = new char[9];
        for (int h = 0; h < 9; h++) {
            for (int v = 0; v < 9; v++) {
                vertical[v] = board[v][h];
            }
            yield return vertical;
        }
    }

    IEnumerable<IEnumerable<char>> Boxes(char[][] board) {
        var vertical = new char[9];
        for (int boxX = 0; boxX < 3; boxX++) {
            for (int boxY = 0; boxY < 3; boxY++) {
                yield return Box(board, boxX, boxY);
            }
        }
    }

    IEnumerable<char> Box(char[][] board, int boxX, int boxY) {
        for (int h = boxX * 3; h < boxX * 3 + 3; h++) {
            for (int v = boxY * 3; v < boxY * 3 + 3; v++) {
                yield return board[v][h];
            }
        }
    }

    bool HasDuplicates(IEnumerable<char> cells) {
        Span<bool> found = stackalloc bool[10];

        foreach (var cell in cells) {
            if (cell == '.') continue;
            int nr = cell - 48;
            if (found[nr]) return true;
            found[nr] = true;
        }

        return false;
    }
}