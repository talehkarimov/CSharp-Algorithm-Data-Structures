namespace CSharp_Solutions.Solutions;

internal class TwoSum
{
    /*
     This method solves the problem where we need to find two elements in an array
     that add up to a specific target number.It uses a dictionary to store the
     difference between the target and the current number, which allows for an
     efficient lookup.
    */

    public int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        return new int[0];
    }
}
