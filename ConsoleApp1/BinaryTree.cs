using System;

namespace ConsoleApp1
{
    public class TreeNode
    {
        public int Contents;
        public TreeNode LeftNode;
        public TreeNode RightNode;

        public TreeNode(int value)
        {
            Contents = value;
            LeftNode = null;
            RightNode = null;
        }

        public void Print()
        {
            Console.WriteLine(Contents);
        }
    }
    public class BinaryTree
    {
        private TreeNode Root;

        public BinaryTree()
        {
            Root = null;
        }
        public void Add(int value)
        {
            TreeNode previous = null, current = Root;

            while (current != null)
            {
                previous = current;
                if (value < current.Contents) current = current.LeftNode;
                else if (value > current.Contents) current = current.RightNode;
                else return;
            }

            TreeNode wta = new TreeNode(value);
            if (previous == null) Root = wta;
            else
            {
                if (value < previous.Contents)
                    previous.LeftNode = wta;
                else
                    previous.RightNode = wta;
            }
        }

        public void Delete(int wtd)
        {
            _delete(Root, wtd);
        }

        private TreeNode _delete(TreeNode node, int wtd)
        {
            if (node == null) return node;
            if (wtd < node.Contents) node.LeftNode = _delete(node.LeftNode, wtd);
            else if (wtd > node.Contents) node.RightNode = _delete(node.RightNode, wtd);
            else
            {
                if (node.LeftNode == null) return node.RightNode;
                else if (node.RightNode == null) return node.LeftNode;
                int tempmin = node.RightNode.Contents;
                while (node.RightNode.LeftNode != null)
                {
                    tempmin = node.RightNode.LeftNode.Contents;
                    node.RightNode = node.RightNode.LeftNode;
                }
                node.Contents = tempmin;
                node.RightNode = _delete(node.RightNode, node.Contents);
            }
            return node;
        }
        
        public TreeNode Search(int wtf)
        {
            return _search(Root, wtf);
        }

        private TreeNode _search(TreeNode node, int wtf)
        {
            if (node == null || wtf == node.Contents) return node;
            if (wtf < node.Contents) return _search(node.LeftNode, wtf);
            return _search(node.RightNode, wtf);
        }
        
        public void Print()
        {
            _print(Root);
        }
        
        private void _print(TreeNode node)
        {
            if (node != null)
            {
                _print(node.LeftNode);
                Console.WriteLine(node.Contents);
                _print(node.RightNode);
            }
        }
    }
}