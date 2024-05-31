// https://leetcode.com/problems/merge-two-sorted-lists/

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var head = new ListNode(0, list1);
        var cur = head;
        var cur2 = list2;

        while (cur2 != null) {
            if (cur.next == null) {
                cur.next = cur2;
                break;
            } else if (cur2.val < cur.next.val) {
                var temp = cur.next;
                cur.next = cur2;
                cur2 = cur2.next;
                cur = cur.next;
                cur.next = temp;
            }
            else {
                cur = cur.next;
            }
        }

        return head.next;
    }
}