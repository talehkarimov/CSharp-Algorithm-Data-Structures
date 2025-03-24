namespace CSharp_Solutions.Solutions;

internal class SingleNumber
{
    /*
    This method finds the element in the array that appears only once, while 
    all other elements appear twice. It uses the XOR bitwise operation, which 
    cancels out elements that appear twice, leaving only the element that appears once.
    */

    public int FindUniqueElement(int[] nums)
    {
        int result = 0;
        foreach (int num in nums)
        {
            result ^= num; // XOR cancels out duplicate numbers
        }
        return result;
    }
}
