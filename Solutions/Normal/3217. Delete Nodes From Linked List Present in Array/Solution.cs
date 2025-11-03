
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
 

public class Solution
{
    public ListNode ModifiedList(int[] nums, ListNode head)
    {
        bool[] used = new bool[100001];
        for (int i = 0; i < nums.Length; i++)
            used[nums[i]] = true;
        ListNode dummy = new ListNode(0, head);
        ListNode pointer = dummy;
        while (pointer.next != null)
        {
            if (used[pointer.next.val])
                pointer.next = pointer.next.next;
            else
                pointer = pointer.next;
        }
        return dummy.next;
    }
}
