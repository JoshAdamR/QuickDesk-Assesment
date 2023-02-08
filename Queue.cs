using QueueList;

namespace BuildQueuing
{
    class FIFOQUEUE : IQueuable
    {
        private LinkList queue;

        public FIFOQUEUE() //Create new list
        {
            queue = new LinkList();
        }

        public string Enqueue(string value)
        {
            queue.AddFromTail(value);
            return GetQueue();
        }

        public string Dequeue()
        {
            return queue.RemoveFromHead();
        }

        public string GetQueue()
        {
            return queue.PrintList();
        }

        public int Size()
        {
            return queue.Size();
        }
    }
}
