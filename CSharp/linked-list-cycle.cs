// https://leetcode.com/problems/linked-list-cycle/
// The O(1) memory solution

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null) return false;

        ListNode slow = head;
        ListNode fast = head.next;

        bool slowMove = false;

        while (fast != null) {
            if (fast == slow) return true;
            fast = fast.next;
            if (slowMove) slow = slow.next;
            slowMove = !slowMove;
        }

        return false;
    }
}