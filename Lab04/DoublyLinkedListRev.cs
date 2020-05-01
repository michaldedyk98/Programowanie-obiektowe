using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class DoublyLinkedListRev<T> : DoublyLinkedList<T>, IEnumerable<T>
    {
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new RevEnumerator(lastElement);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new RevEnumerator(lastElement);
        }
    }
}
