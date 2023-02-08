﻿namespace BuildQueuing
{
    interface IQueuable 
    {
        string Enqueue(string value); //Should add item to list

        string Dequeue(); //Remove item from lisdt

        string GetQueue(); //Display list

        int Size(); //Get total items in list
    }
}
