using QueueList;

namespace BuildQueuing
{
    abstract class QueueBase : IQueuable
    {
        public LinkList? GetList { get; set; }

        public string Enqueue(string value) //Add item from rear end of list
        {
            GetList!.AddFromTail(value);
            return GetQueue();
        }



        virtual public string Dequeue() //Remove item from front
        {
            return GetList!.RemoveFromHead();
        }



        public string GetQueue() //Display list
        {
            return GetList!.PrintList();
        }



        public int Size() //Get total items in list
        {
            return GetList!.Size();
        }
    }
}
