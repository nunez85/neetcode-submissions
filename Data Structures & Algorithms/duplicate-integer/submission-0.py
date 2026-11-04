class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        mSet = set()
        for n in nums:
            if n in mSet:
                return True
            else:
                mSet.add(n)
        
        return False
        