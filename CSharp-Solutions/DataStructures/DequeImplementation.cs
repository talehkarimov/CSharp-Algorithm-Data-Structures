namespace CSharp_Solutions.DataStructures;

internal class DequeImplementation
{
    // This class implements a basic data structure that follows the Double-Ended Queue principle.
    // It allows adding and removing elements from both ends of the collection.

    public class DequeUsingList<T>
    {
        private LinkedList<T> deque = new LinkedList<T>();

        public void AddFront(T item) => deque.AddFirst(item);
        public void AddBack(T item) => deque.AddLast(item);

        public T RemoveFront()
        {
            if (deque.Count == 0) throw new InvalidOperationException("Deque is empty");
            T value = deque.First.Value;
            deque.RemoveFirst();
            return value;
        }

        public T RemoveBack()
        {
            if (deque.Count == 0) throw new InvalidOperationException("Deque is empty");
            T value = deque.Last.Value;
            deque.RemoveLast();
            return value;
        }
    }

}
