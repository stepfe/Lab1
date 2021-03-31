using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class LinkedList
    {
        Node head;
        Node tale;


        public LinkedList()
        {
            head = null;
            tale = null;
        }

        public void pushBack(Node node)
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

        public void pushForward(Node node)
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

        public void remove_last()
        {
            if (head == null)
                return;
            if(head == tale)
            {
                head = null;
                tale = null;
                return;
            }

            Node c = tale.getPrev();
            c.setNext(null);
            tale = c;
        }

        public void remove_first()
        {
            if (head == null)
                return;
            if (head == tale)
            {
                head = null;
                tale = null;
                return;
            }

            Node c = head.getNext();
            c.setPrev(null);
            head = c;
        }

        public void reverse()
        {
            Node newHead = tale;
            Node newTale = tale;
            Node newItem = tale.getPrev();
            while(newItem != null)
            {
                Node h = newItem.getPrev();
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

        public void print()
        {
            Node c = head;
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
                remove_last();
            }
        }
    }
}
