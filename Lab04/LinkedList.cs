using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public partial class LinkedList<T>
    {
        private class Node
        {
            public T element { get; set; }
            public Node next;

            public Node(T el) { element = el; }

            public Node() { next = null; }
        }

        private int size;
        private Node firstElement = null;
        private Node lastElement = null;

        public int Size { get => size; }

        public void Add(T element)
        {
            if (firstElement == null)
                firstElement = lastElement = new Node(element);
            else
                lastElement = lastElement.next = new Node(element);

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

            if (i == 0)
                firstElement = firstElement.next;
            else
            {
                Node nElement = Get(i - 1);

                if (nElement != null)
                {
                    if (i == Size - 1)
                        lastElement = nElement;

                    nElement.next = nElement.next.next;
                }

                else return;
            }

            size--;

            if (size == 0)
                lastElement = null;
        }

        public void Remove(T element)
        {
            if (Size == 0) throw new KeyNotFoundException(); // Na pewno nie znajduje sie w liscie

            Node nextElement = firstElement;
            Node prevElement = null;
            while (nextElement != null)
            {
                if (element.Equals(nextElement.element)) break;
                prevElement = nextElement;
                nextElement = nextElement.next;
            }

            if (nextElement == null) throw new KeyNotFoundException();

            if (prevElement == null) // Element jest pierwszy na liscie
                firstElement = firstElement.next;
            else
            {
                if (nextElement.next == null) // Ostatni element na liscie
                    lastElement = prevElement;
                prevElement.next = nextElement.next;
            }

            size--;

            if (size == 0)
                lastElement = null;
        }

        public void Insert(int i, T element)
        {
            if (i > Size) throw new IndexOutOfRangeException();

            if (i == 0) {
                Node nTemp = firstElement;

                firstElement = new Node(element);
                firstElement.next = firstElement;

                if (lastElement == null)
                    lastElement = firstElement;
            } else
            {
                Node nElement = Get(i - 1);

                if (nElement != null)
                {
                    Node nNext = nElement.next;

                    nElement.next = new Node(element);
                    nElement.next.next = nNext;

                    if (i == Size)
                        lastElement = nElement.next;
                } else throw new IndexOutOfRangeException();
            }

            size++;
        }
    }
}
