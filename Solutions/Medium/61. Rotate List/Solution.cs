
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
 
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(k == 0 || head == null || head.next == null) return head;
        ListNode headCopy = head;
        int listLength = 0;
        while(headCopy != null){
            headCopy = headCopy.next;
            listLength++;
        }
        int rotation = k % listLength;
        headCopy = head;
        for(int i = 0; i < listLength - rotation - 1; i++){
            headCopy = headCopy.next;
        }
        ListNode tail = headCopy.next;
        headCopy.next = null;
        ListNode tailCopy = tail;
        while(tailCopy.next != null){
            tailCopy = tailCopy.next;
        }
        tailCopy.next = head;
        return tail;
    }
}