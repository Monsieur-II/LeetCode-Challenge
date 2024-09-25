using Csharp;
using Problems = Csharp.LeetCodeChallenge;

var list1 = new ListNode(2, new ListNode(4));
list1.next!.next = new ListNode(3);

var list2 = new ListNode(5, new ListNode(6));
list2.next!.next = new ListNode(4);

var result = Problems.AddTwoNumbers(list1, list2);

while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}
