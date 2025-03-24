namespace CSharp_Solutions.Solutions;

internal class MajorityElement
{
    /*
    This method identifies the element in an array that appears more than half 
    of the total number of elements. It does this by maintaining a candidate 
    and counting the occurrences while iterating over the array.
    */

    public int FindMajorityElement(int[] nums)
    {
        int count = 0, candidate = 0;
        foreach (int num in nums)
        {
            if (count == 0)
                candidate = num;
            count += (num == candidate) ? 1 : -1;
        }
        return candidate;
    }
}
