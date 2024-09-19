using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBinaryTree
{
    public class BSTNode<T>
    {
        public T Data { get; set; }
        public BSTNode<T> Left { get; set; }
        public BSTNode<T> Right { get; set; }

        public BSTNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

}
