using CSharp_Solutions.DataStructures;

namespace CSharp_Solutions.Solutions;

internal class IntersectionTwoLinkedList
{
    // Singly Linked List
    // 1 - [4,1,8,4,5] 
    // 2 - [5,6,1,8,4,5]
    // result  = 8

    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;
        var firstPointer = headA;
        var secondPointer = headB;
        while (firstPointer != secondPointer)
        {
            firstPointer = firstPointer == null ? headB : firstPointer.next;
            secondPointer = secondPointer == null ? headA : secondPointer.next;
        }

        return firstPointer;
    }
}
