class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        l = 0
        h = k
        if(k == 0):
            return False

        if(k == len(nums)):
            if(nums[l] == nums[len(nums)-1] and l != len(nums)-1):
                return True
        elif(k > len(nums)):
            for i in range(len(nums)):
                for j in range(i,len(nums)):
                    if(nums[i] == nums[j]):
                        return True
            return False
        while(l < len(nums)-k):
            interieur = h
            while(l < interieur):
                if(nums[l] == nums[interieur]):
                    return True
                interieur -=1
            l += 1
            h += 1
        
        return False