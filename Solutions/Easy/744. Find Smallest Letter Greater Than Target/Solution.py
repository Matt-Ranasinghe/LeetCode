class Solution:
    def nextGreatestLetter(self, letters: List[str], target: str) -> str:
        result = "zz"
        for c in letters:
            if (c <= target):
                continue
            if (c < result):
                result = c
        if (result == "zz"):
            return letters[0]
        return result