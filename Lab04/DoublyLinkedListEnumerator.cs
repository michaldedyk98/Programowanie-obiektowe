using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public partial class DoublyLinkedList<T> : IEnumerable<T>
    {
        protected class RevEnumerator : IEnumerator<T>
        {
            protected Node firstNode, currentNode;

            public RevEnumerator(Node first)
            {
                this.firstNode = first = currentNode = new Node { prev = first };
            }

            public T Current => this.currentNode.element;

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                if (currentNode != null)
                    currentNode = currentNode.prev;
                return currentNode != null;
            }

            public void Reset()
            {
                currentNode = firstNode;
            }
        }

        class ForwardEnumerator : IEnumerator<T>
        {
            protected Node firstNode, currentNode;

            public ForwardEnumerator(Node first)
            {
                this.firstNode = first = currentNode = new Node { next = first };
            }

            public T Current => this.currentNode.element;

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                if (currentNode != null)
                    currentNode = currentNode.next;
                return currentNode != null;
            }

            public void Reset()
            {
                currentNode = firstNode;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new ForwardEnumerator(firstElement);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ForwardEnumerator(firstElement);
        }
    }
}
