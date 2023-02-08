namespace QueueList
{
    class LinkList
    {
        private static LinkList? _list;

        private LinkList() 
        {
            head = null;
            tail = null;
            count = 0;
        }

        public static LinkList NewList() //To create new list
        {
            _list = new LinkList();
            return _list;
        }



        class Node //create a node
        {
            public string Data;
            public Node? Next;
            public Node? Prev;

            public Node(string value)
            {
                Data = value;
                Next = null;
                Prev = null;
            }
        }

        private int count; //to keep track of number of list
        private Node? head;
        private Node? tail;



        public void AddFromTail(string value) //Add node to the tail
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Prev = tail;
                tail!.Next = newNode;
                tail = newNode;
            }
            count++;
        }



        private string RemoveNode(Node? node) //Remove node from head if true, remove tail if false
        {

            if (node != null)
            {
                if (node == head)
                {
                    head = node.Next;
                    if (head != null)
                    {
                        head.Prev = null;
                    }
                }
                else
                {
                    tail = node.Prev;
                    if (tail != null)
                    {
                        tail.Next = null;
                    }
                }

                node.Prev = null;
                node.Next = null;
                count--;
                
                return node.Data;
            }
            else
            {
                return "List is empty";
            }
            
        }

        public string RemoveFromHead()
        {
            return RemoveNode(head);
        }

        public string RemoveFromTail()
        {
            return RemoveNode(tail);
        }



        public string PrintList() //Print all, O(n) 
        {
            if (head != null)
            {
                Node? runner = head.Next;
                string listNode = head.Data;
                while (runner != null)
                {
                    listNode += "," + runner.Data;
                    runner = runner.Next;
                }
                return listNode;
            }
            else
            {
                return "List is empty";
            }
        }

        

        public int Size()
        {
            return count;
        }
    }

}