class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        sd = dict()
        st = dict()

        for c in s:
            if c in sd:
                sd[c] += 1
            else:
                sd[c] = 0
        
        for c in t:
            if c in st:
                st[c] += 1
            else:
                st[c] = 0

        return sd == st

        

        
        