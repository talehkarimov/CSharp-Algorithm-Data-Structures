namespace CSharp_Solutions.Solutions;

internal class DailyTemperatures
{
    /*
    This method calculates the number of days until the temperature becomes warmer 
    for each day in the array. It uses a stack to store indices of the days 
    and computes the difference between the current day and the days with higher temperatures.
    */

    public int[] CalculateDaysToWarmerTemperature(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int index = stack.Pop();
                result[index] = i - index;
            }
            stack.Push(i);
        }
        return result;
    }
}
