

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
         this.next = next;
    }
}

public class Solution {
    public int PairSum(ListNode head) {
        List<int> listForm = new List<int>();
        while(head != null){
            listForm.Add(head.val);
            head = head.next;
        }
        int result = 0;
        int n = listForm.Count;
        for(int i = 0; i < n / 2; i++){
            result = Math.Max(result, listForm[i] + listForm[n - i - 1]);
        }
        return result;
    }
}