using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBinaryTree
{
    public class BinarySearchTree<T> where T : Character
    {
        private BSTNode<T> root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(T character)
        {
            root = InsertRec(root, character);
        }

        private BSTNode<T> InsertRec(BSTNode<T> node, T character)
        {
            if (node == null)
            {
                return new BSTNode<T>(character);
            }

            // First compare by Power
            if (character.Power < node.Data.Power)
            {
                node.Left = InsertRec(node.Left, character);
            }
            else if (character.Power > node.Data.Power)
            {
                node.Right = InsertRec(node.Right, character);
            }
            else
            {
                // If Power is the same, compare by Speed
                if (character.Speed < node.Data.Speed)
                {
                    node.Left = InsertRec(node.Left, character);
                }
                else
                {
                    node.Right = InsertRec(node.Right, character);
                }
            }

            return node;
        }

        // Display the tree in-order (sorted by Power and Speed)
        public void InOrderTraversal(Action<T> action)
        {
            InOrderRec(root, action);
        }

        private void InOrderRec(BSTNode<T> node, Action<T> action)
        {
            if (node != null)
            {
                InOrderRec(node.Left, action);
                action(node.Data);
                InOrderRec(node.Right, action);
            }
        }
    }

}
