using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.BFS
{
    class Tree
    {
        public Node root;              //variaable node root to store root value
        void BinaryTree()
        {
            root = null;
        }
        public void PrintBFS(Node root)   //function to print tree through BFS
        {
            int h = height(root);
            int i;
            for (i = 0; i < h; i++)        //for loop to print every level
            {
                PrintGivenLevel(root,i);  //function call to print specific 
            }

        }
        public int height(Node root)      //function to calculate height of tree
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int leftHeight = height(root.left);      //recurssion to go to left of the tree
                int rightHeight = height(root.right);    //recursion to go to right of the tree
                if (leftHeight > rightHeight)
                {
                    return (leftHeight + 1);
                }
                else
                {
                    return (rightHeight + 1);
                }
            }
        }
        public void PrintGivenLevel(Node root,int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 0)
            {
                Console.WriteLine(root.data);    //if level 0 means there is only one node
            }
            else
            {
                PrintGivenLevel(root.left, level - 1);  
                PrintGivenLevel(root.right, level - 1);
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                Tree tree = new Tree();
                tree.root = new Node(1);               //pre defined elements in the tree
                tree.root.left = new Node(2);
                tree.root.right = new Node(3);
                tree.root.left.left = new Node(4);
                tree.root.left.right = new Node(5);
                tree.root.right.left = new Node(6);
                Console.WriteLine("BFS traversal of binary tree is: ");
                tree.PrintBFS(tree.root);                 //calling print BFS to print tree breath first way
                Console.ReadKey();
            }
            catch (Exception e)                   //catch block to handle any exception if occurs
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Node                               //node class to use it as a structure for a node
    {
        public int data;
        public Node left, right;
        public Node(int item)
        {
            data = item;
            left = right = null;
        }


    }
}
