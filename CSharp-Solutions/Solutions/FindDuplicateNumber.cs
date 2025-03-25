namespace CSharp_Solutions.Solutions;

internal class FindDuplicateNumber
{
    public int FloydSolution(int[] nums)
    {
        int slowPointer = nums[0];
        int fastPointer = nums[0];

        // Step 1: Detect cycle
        do
        {
            slowPointer = nums[slowPointer]; // Move 1 step
            fastPointer = nums[nums[fastPointer]]; // Move 2 steps
        } while (slowPointer != fastPointer);

        // Step 2: Find the entrance to the cycle
        slowPointer = nums[0];
        while (slowPointer != fastPointer)
        {
            slowPointer = nums[slowPointer];
            fastPointer = nums[fastPointer];
        };

        return slowPointer;
    }
}
