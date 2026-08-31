/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        int prev = head.val;
        head = head.next;
        int prevCrit = -1, firstCrit = -1;
        int minGap = Int32.MaxValue;
        int count = 1;
        while(head.next != null){
            int next = head.next.val;
            int curr = head.val;
            if((curr < next && curr < prev) || (curr > next && curr > prev)){
                if(firstCrit == -1) firstCrit = count;
                else{
                    minGap = Math.Min(minGap, count - prevCrit);
                }
                prevCrit = count;
            }
            count++;
            prev = curr;
            head = head.next;
        }
        if(minGap == Int32.MaxValue) return new int[2] {-1, -1};
        else return new int[2] {minGap, prevCrit - firstCrit};
    }
}