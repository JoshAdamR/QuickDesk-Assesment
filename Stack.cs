namespace BuildQueuing
{
    class LIFOQUEUE : QueueBase
    {
        public override string Dequeue() //Change Dequeue() method operation
        {
            return GetList.RemoveFromTail();
        }
    }
}