class Solution:
    def countCollisions(self, directions: str) -> int:
        result: int = 0
        direction_stack: list[str] = []
        for c in directions:
            if (len(direction_stack) == 0):
                if (c != 'L'):
                    direction_stack.append(c)
            else:
                if (c == 'L'):
                    result += 1
                    direction_stack.append('S')
                else:
                    direction_stack.append(c)
        seen_stationary: bool = False
        while (len(direction_stack) > 0):
            if (seen_stationary):
                if (direction_stack.pop() == 'R'):
                    result += 1
            else:
                seen_stationary = direction_stack.pop() == 'S'
        return result