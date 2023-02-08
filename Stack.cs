using QueueList;

namespace BuildQueuing
{
    class LIFOQUEUE : IQueuable
    {
        private LinkList stack;

        public LIFOQUEUE() //Create new list
        {
            stack = new LinkList();
        }

        public string Enqueue(string value)
        {
            stack.AddFromTail(value);
            return GetQueue();
        }

        public string Dequeue()
        {
            return stack.RemoveFromTail();
        }

        public string GetQueue()
        {
            return stack.PrintList();
        }

        public int Size()
        {
            return stack.Size();
        }
    }
}