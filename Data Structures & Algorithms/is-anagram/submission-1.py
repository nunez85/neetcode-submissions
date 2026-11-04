class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False


        offset = ord('a')
        count = [0] * 26
        for i in range(len(s)):
            count[ord(s[i]) - offset] += 1
            count[ord(t[i]) - offset] -= 1
        
        for val in count:
            if val != 0:
                return False

        return True