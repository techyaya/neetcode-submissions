public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        for(int i= 0;i<matrix.Length;i++)
        {
            int l = 0;
            int h = matrix[0].Length -1 ;
            while(l <= h)
            {
                int mid = (l + h)/2;
                if(matrix[i][mid] == target)
                {
                    return true;
                }
                else if(matrix[i][mid] > target)
                {
                    h = mid -1;
                }
                else
                {
                    l = mid +1;
                }
            }

        }
        return false;
    }
}
