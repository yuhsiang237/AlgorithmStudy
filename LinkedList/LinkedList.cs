using System;

namespace LinkedList
{
    /// <summary>
    /// LinkedList
    /// </summary>
    class LinkedList
    {
        private Node head;

        /// <summary>
        /// travel and print all linked list data
        /// time complexity O(n)
        /// </summary>
        public void PrintAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next; 
            }
        }

        /// <summary>
        /// push a data to the front of linked list.
        /// time complexity O(1)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public LinkedList PushFront(Object data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            return this;
        }

        /// <summary>
        /// push a data to the end of linked list.
        /// time complexity O(n)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public LinkedList PushBack(Object data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null) // traverse all nodes to the end of linked list
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            return this;
        }
    }
}
