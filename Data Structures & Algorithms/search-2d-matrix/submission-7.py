class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        
        for i in range(len(matrix)):
            l = 0
            h = len(matrix[i])-1
            while(l <= h ):
                mid = (l+h) // 2
                if(target == matrix[i][mid]):
                    return True
                elif(target > matrix[i][mid]):
                    l = mid +1
                else:
                    h = mid -1

        return False