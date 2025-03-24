namespace CSharp_Solutions.Solutions;

internal class ContainsDuplicate
{
    /*
    This method checks whether a given array contains any duplicate elements. 
    It uses a HashSet to store the numbers, and if an element is already present 
    in the set, it returns true indicating a duplicate is found.
    */

    public bool CheckForDuplicates(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in nums)
        {
            if (!set.Add(num))
                return true;
        }
        return false;
    }
}
