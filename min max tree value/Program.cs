using System;

namespace _63._20
{
    class Program
    {
        //63/20
        public static void Main(string[] args)
        {
        }
    }
    public class BinaryTree
    {
        public int MinValueTree(Node node)
        {
            Node parentNode = node;

            while (parentNode.left != null)
            {
                parentNode = parentNode.left;
            }
            return parentNode.value;
        }
        public int MaxValueTree(Node node)
        {
            Node parentNode = node;

            while (parentNode.right != null)
            {
                parentNode = parentNode.right;
            }
            return parentNode.value;
        }
    }
    public class Node
    {
        public int value;
        public Node left, right;

        public Node(int number)
        {
            value = number;
            left = null;
            right = null;
        }
    }
}