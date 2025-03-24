namespace CSharp_Solutions.DataStructures;

internal class StackImplementation
{
    /*
    This class implements a basic data structure that follows the LIFO (Last-In-First-Out) principle.
    It uses a list to manage the collection of items, allowing for adding elements to the end
    and removing them from the end.
    */

    public class StackUsingList<T>
    {
        private List<T> list = new List<T>();

        public void Push(T item) => list.Add(item);

        public T Pop()
        {
            if (list.Count == 0) throw new InvalidOperationException("Stack is empty");
            T value = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return value;
        }

        public T Peek() => list.Count > 0 ? list[list.Count - 1] : throw new InvalidOperationException("Stack is empty");

        public bool IsEmpty() => list.Count == 0;
    }
}
