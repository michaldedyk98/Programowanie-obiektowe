using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public partial class DoublyLinkedList<T>
    {
        protected class Node
        {
            public T element { get; set; }
            public Node next, prev;

            public Node(T el) { element = el; }

            public Node() { next = null; }
        }

        protected int size;
        protected Node firstElement = null;
        protected Node lastElement = null;

        public int Size { get => size; }

        public void Add(T element)
        {
            if (firstElement == null)
                firstElement = lastElement = new Node(element);
            else
                lastElement = lastElement.next = new Node(element) { prev = lastElement };

            size++;
        }

        private Node Get(int i)
        {
            if (i >= Size) throw new IndexOutOfRangeException();

            Node nextElement = firstElement;
            while (i-- > 0 && nextElement != null)
                nextElement = nextElement.next;

            if (nextElement == null) throw new IndexOutOfRangeException();

            return nextElement;
        }

        public void RemoveAt(int i)
        {
            if (i >= Size) throw new IndexOutOfRangeException();


            Node nextElement = Get(i - 1);

            if (nextElement == null) throw new IndexOutOfRangeException();

            if (nextElement.prev == null) // Pierwsza
            {
                firstElement = nextElement.next;
                firstElement.prev = null;
            }
            else if (nextElement.next == null) // Ostatnia
            {
                lastElement = nextElement.prev;
                lastElement.next = null;
            }
            else // Srodek
            {
                nextElement.prev.next = nextElement.next;
                nextElement.next.prev = nextElement.next;
            }

            size--;

            if (size == 0)
                lastElement = null;
        }

        public void Remove(T element)
        {
            if (Size == 0) throw new KeyNotFoundException(); // Na pewno nie znajduje sie w liscie

            Node nextElement = firstElement;
            while (nextElement != null)
            {
                if (element.Equals(nextElement.element)) break;
                nextElement = nextElement.next;
            }

            if (nextElement == null) throw new KeyNotFoundException();

            if (nextElement.prev == null) // Pierwsza
            {
                firstElement = nextElement.next;
                firstElement.prev = null;
            } else if (nextElement.next == null) // Ostatnia
            {
                lastElement = nextElement.prev;
                lastElement.next = null;
            } else // Srodek
            {
                nextElement.prev.next = nextElement.next;
                nextElement.next.prev = nextElement.prev;
            }

            size--;

            if (size == 0)
                lastElement = null;
        }

        public void Insert(int i, T element)
        {
            bool bFirst = i == 0;
            Node nNode = firstElement;

            while (nNode != null && i-- > 0)
                nNode = nNode.next;

            if (nNode == null)
                throw new IndexOutOfRangeException();

            Node nNew = nNode.prev = new Node() { element = element, next = nNode, prev = nNode.prev };
            if (nNew.prev != null)
                nNew.prev.next = nNew;

            if (bFirst)
            {
                firstElement = nNew;

                if (lastElement == null)
                    lastElement = firstElement;
            }
            size++;
        }
    }
}
