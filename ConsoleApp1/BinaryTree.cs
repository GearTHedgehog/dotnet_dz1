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
            Delete(Root, wtd);
        }

        private TreeNode Delete(TreeNode node, int wtd)
        {
            if (node == null) return node;
            if (wtd < node.Contents) node.LeftNode = Delete(node.LeftNode, wtd);
            else if (wtd > node.Contents) node.RightNode = Delete(node.RightNode, wtd);
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
                node.RightNode = Delete(node.RightNode, node.Contents);
            }
            return node;
        }
        
        public TreeNode Search(int wtf)
        {
            return Search(Root, wtf);
        }

        private TreeNode Search(TreeNode node, int wtf)
        {
            if (node == null || wtf == node.Contents) return node;
            if (wtf < node.Contents) return Search(node.LeftNode, wtf);
            return Search(node.RightNode, wtf);
        }
        
        public void Print()
        {
            Print(Root);
        }
        
        private void Print(TreeNode node)
        {
            if (node != null)
            {
                Print(node.LeftNode);
                Console.WriteLine(node.Contents);
                Print(node.RightNode);
            }
        }
    }
}