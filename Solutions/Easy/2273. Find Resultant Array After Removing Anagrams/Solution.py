class Solution:
    def removeAnagrams(self, words: list[str]) -> list[str]:
        if len(words) == 1:
            return words
        res: list[str] = [words[0]]
        sortedString: str = ''.join(sorted(words[0]))
        prev: str = sortedString
        for i in range(1, len(words)):
            sortedString = ''.join(sorted(words[i]))
            if (prev != sortedString):
                res.append(words[i])
                prev = sortedString
        return res
