using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex58____Trees
{
    public class MyBST<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
        }

        private Node root;

        private void InsertHelper(T item, Node root)
        {
            // Item er større end root data
            if (item.CompareTo(root.Data) > 0)
            {
                if (root.RightChild == null)
                {
                    root.RightChild = new Node { Data = item };
                }
                else
                {
                    InsertHelper(item, root.RightChild);
                }
            }
            //Item er mindre end root data
            if (item.CompareTo(root.Data) < 0)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = new Node { Data = item };
                }
                else
                {
                    InsertHelper(item, root.LeftChild);
                }
            }
        }
        public void Insert(T item)
        {
            if (root == null)
                root = new Node { Data = item };
            else
                InsertHelper(item, root);
        }

        private void InOrderHelper(Node root, List<T> list)
        {
            if (root != null)
            {
                InOrderHelper(root.LeftChild, list);
                list.Add(root.Data);
                InOrderHelper(root.RightChild, list);
            }
        }
        public List<T> InOrder()
        {
            List<T> list = new List<T>();

            InOrderHelper(root, list);

            return list;
        }

        public List<T> PreOrderTrav()
        {
            List<T> preorder = new List<T>();
            PreOrderHelper(root, preorder);
            return preorder;
        }
        private void PreOrderHelper(Node root, List<T> list)
        {
            //Check selv, venstre, højre, en op REGLEN!!!!!
            if (root != null)
            {
                list.Add(root.Data);
                PreOrderHelper(root.LeftChild, list);
                PreOrderHelper(root.RightChild, list);
            }
        }

        public List<T> PostOrderTrav()
        {
            List<T> postorder = new List<T>();
            PostOrderHelper(root, postorder);
            return postorder;
        }
        private void PostOrderHelper(Node root, List<T> list)
        {

        }
    }
}
