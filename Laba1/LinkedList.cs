using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public class LinkedList<T>
    {
        Node<T> head;
        Node<T> tale;


        public LinkedList()
        {
            head = null;
            tale = null;
        }

       

        public void pushBack(Node<T> node)
        {
            if(head == null)
            {
                head = node;
                tale = node;
            }
            else
            {
                tale.setNext(node);
                node.setPrev(tale);
                tale = node;
            }
        }

        public void pushForward(Node<T> node)
        {
            if (head == null)
            {
                head = node;
                tale = node;
            }
            else
            {
                head.setPrev(node);
                node.setNext(head);
                head = node;
            }
        }

        public Node<T> popLast()
        {
            if (head == null)
                return head;

            Node<T> h = tale;
            if (head == tale)
            {
                head = null;
                tale = null;
                return h;
            }

            Node<T> c = tale.getPrev();
            c.setNext(null);
            tale = c;

            return h;
        }

        public Node<T> popFirst()
        {
            if (head == null)
                return head;
            Node<T> h = head;
            if (head == tale)
            {
                head = null;
                tale = null;
                return h;
            }

            Node<T> c = head.getNext();
            c.setPrev(null);
            head = c;
            return h;
        }

        public void reverse()
        {
            if (head != null)
            {
                Node<T> newHead = tale;
                Node<T> newTale = tale;
                Node<T> newItem = tale.getPrev();
                while (newItem != null)
                {
                    Node<T> h = newItem.getPrev();
                    newItem.setPrev(newTale);
                    newTale.setNext(newItem);
                    newTale = newItem;
                    newItem = h;
                }
                newHead.setPrev(null);
                newTale.setNext(null);
                tale = newTale;
                head = newHead;
            }
        }

        public void print()
        {
            Node<T> c = head;
            while (c != null)
            {
                Console.WriteLine(c.getData());
                c = c.getNext();
            }
        }

        ~LinkedList()
        {
            while(head != null)
            {
                popLast();
            }
        }
    }
}
