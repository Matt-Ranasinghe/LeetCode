class Solution:
    def bestClosingTime(self, customers: str) -> int:
        current: int = customers.count('Y')
        min_penalty: int = current
        close: int = 0
        for i, c in enumerate(customers):
            if(c == 'Y'):
                current -= 1
                if(min_penalty > current):
                    min_penalty = current
                    close = i + 1
            else:
                current += 1
        return close
            