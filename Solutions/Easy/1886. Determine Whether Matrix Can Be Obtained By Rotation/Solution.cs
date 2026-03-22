public class Solution {
    public bool FindRotation(int[][] mat, int[][] target) {
        for (int rot = 0; rot < 4; rot++) {
            if (AreMatricesEqual(mat, target)) return true;
            Rotate90(mat);
        }
        return false;
    }

    private void Rotate90(int[][] mat) {
        int n = mat.Length;
        for (int i = 0; i < n / 2; i++) {
            int[] temp = mat[i];
            mat[i] = mat[n - 1 - i];
            mat[n - 1 - i] = temp;
        }
        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                int temp = mat[i][j];
                mat[i][j] = mat[j][i];
                mat[j][i] = temp;
            }
        }
    }

    private bool AreMatricesEqual(int[][] a, int[][] b) {
        for (int i = 0; i < a.Length; i++) {
            if (!a[i].SequenceEqual(b[i])) return false;
        }
        return true;
    }
}