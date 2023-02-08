namespace BuildQueuing
{
    class LIFOQUEUE : IQueuable
    {
        private string[] _queue;
        private int _size;

        public LIFOQUEUE()
        {
            _queue = new string[0];
            _size = 0;
        }

        public string Enqueue(string value) //rebuild array to add more item
        {
            int newSize = _size + 1;
            string[] newQueue = new string[newSize];
            for (int i = 0; i < _size; i++)
            {
                newQueue[i] = _queue[i];
            }
            newQueue[newSize - 1] = value;
            _queue = newQueue;
            _size = newSize;
            return GetQueue();
        }

        public string Dequeue() //rebuild array and remove more item
        {
            string item = _queue[_size - 1];
            int newSize = _size - 1;
            string[] newQueue = new string[newSize];
            for (int i = 0; i < newSize; i++)
            {
                newQueue[i] = _queue[i];
            }
            _queue = newQueue;
            _size = newSize;
            return item;
        }

        public string GetQueue() //Join items into string
        {
            string joinedItem = _queue[0];
            for (int i = 1; i < _queue.Length; i++)
            {
                joinedItem += "," + _queue[i];

            }
            return joinedItem;
        }

        public int Size()
        {
            return _size;
        }
    }
}