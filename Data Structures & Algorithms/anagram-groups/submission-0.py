class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        seen = dict()

        for s in strs:
            s_sorted = str(sorted(s))
            if s_sorted in seen:
                seen[s_sorted].append(s)
            else:
                seen[s_sorted] = [s]

        return list(seen.values())

        