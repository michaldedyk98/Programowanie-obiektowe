using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public partial class LinkedList<T> : IEnumerable<T>
    {
        class ListEnumerator : IEnumerator<T>
        {
            Node firstNode, currentNode;

            public ListEnumerator(Node first)
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
            return new ListEnumerator(firstElement);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ListEnumerator(firstElement);
        }
    }
}
