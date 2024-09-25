namespace Csharp;

// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
//
// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Example 1:
// Input: l1 = [2,4,3], l2 = [5,6,4]
// Output: [7,0,8]
// Explanation: 342 + 465 = 807.

public static partial class LeetCodeChallenge
{
    public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        int carry = 0;
        var head = new ListNode();
        var current = head;

        while (l1 != null || l2 != null || carry > 0)
        {
            int value1 = l1?.val ?? 0;
            int value2 = l2?.val ?? 0;

            var sum = value1 + value2 + carry;
            current.next = new ListNode(sum % 10);
            carry = sum / 10;

            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        return head.next;
    }
}


//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}
