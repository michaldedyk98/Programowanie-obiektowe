using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public partial class Tree<T>
    {
        private class Node
        {
            public T element { get; set; }
            public Node child;
            public IList<Node> siblings;
        }
    }
}
