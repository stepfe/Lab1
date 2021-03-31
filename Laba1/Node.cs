using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public class Node<T>
    {
        T data;
        Node<T> next;
        Node<T> prev;

        public Node(T value)
        {
            data = value;
            next = null;
            prev = null;
        }

        public T getData()
        {
            return data;
        }
        public void setNext(Node<T> node)
        {
            next = node;
        }

        public Node<T> getNext()
        {
            return next;
        }

        public void setPrev(Node<T> node)
        {
            prev = node;
        }

        public Node<T> getPrev()
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
