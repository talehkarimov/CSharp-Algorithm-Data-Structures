namespace CSharp_Solutions.DataStructures;

internal class QueueImplementationUsingList
{
    /*
    This class implements a basic data structure that follows the FIFO (First-In-First-Out) principle.
    It uses a list to manage the collection of items, allowing for adding elements to the end
    and removing them from the front.
    */

    public class QueueUsingList<T>
    {
        private List<T> list = new List<T>();

        public void Enqueue(T item) => list.Add(item);

        public T Dequeue()
        {
            if (list.Count == 0) throw new InvalidOperationException("Queue is empty");
            T value = list[0];
            list.RemoveAt(0);
            return value;
        }

        public bool IsEmpty() => list.Count == 0;
    }

}
