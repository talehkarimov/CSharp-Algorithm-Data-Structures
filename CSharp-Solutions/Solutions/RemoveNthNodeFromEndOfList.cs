using CSharp_Solutions.DataStructures;

namespace CSharp_Solutions.Solutions;

internal class RemoveNthNodeFromEndOfList
{
    // Singly-Linked-List
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var x = head;
        var y = head;
        if (y is null) throw new Exception("Invalid data");

        while (n > 0 && y != null)
        {
            y = y.next;
            n--;
        }

        if (y == null)
            return head.next;

        while (y != null && y.next != null)
        {
            x = x.next;
            y = y.next;
        }

        x.next = x.next.next;
        return head;
    }
}

