using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree_Assess
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {  //root declared as protected in Parent Class – Binary Tree

        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public int Height()
        {
            return height(root);

        }

        protected int height(Node<T> tree)
        {
            if (tree == null)
                return -1;
            else
            {
                //compute the depth of each subtree 
                int lHeight = height(tree.Left);
                int rHeight = height(tree.Right);

                //use the larger one 
                if (lHeight > rHeight)
                    return (lHeight + 1);
                else
                    return (rHeight + 1);
            }
        }

        public int Count()
        //Return the number of nodes contained in the tree
        {
            return count(root);
        }

        private int count(Node<T> tree)
        {
            // if it's null, it doesn't exist, return 0 
            if (tree == null)
                return 0;
            // count myself + my left child + my right child
            return 1 + count(tree.Left) + count(tree.Right);
        }

        

    }
}
