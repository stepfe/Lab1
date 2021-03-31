using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Node
    {
        int data;
        Node next;
        Node prev;

        public Node(int value)
        {
            data = value;
            next = null;
            prev = null;
        }

        public int getData()
        {
            return data;
        }
        public void setNext(Node node)
        {
            next = node;
        }

        public Node getNext()
        {
            return next;
        }

        public void setPrev(Node node)
        {
            prev = node;
        }

        public Node getPrev()
        {
            return prev;
        }

        ~Node()
        {
            next = null;
            prev = null;
        }

    }
}
