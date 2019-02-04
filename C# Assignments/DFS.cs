using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.DFS
{
    class Tree
    {
        public Node root=null;                  //initializing root node
        public void PrintInOrder(Node root)     //Inorder function to print tree using inorder traversal
        {
            if (root == null)
            {
                return;
            }
            else
            {
                PrintInOrder(root.left);
                Console.WriteLine(root.data);
                PrintInOrder(root.right);
            }

        }
        public void PrintPreOrder(Node root)     //Preorder function to print tree using inorder traversal
        {
            if (root == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(root.data);
                PrintInOrder(root.left);
                PrintInOrder(root.right);
            }

        }
        public void PrintPostOrder(Node root)     //Postorder function to print tree using inorder traversal
        {
            if (root == null)
            {
                return;
            }
            else
            {
                PrintInOrder(root.left);
                PrintInOrder(root.right);
                Console.WriteLine(root.data);
            }

        }


        static void Main(string[] args)
        {
            try
            {
                Tree tree = new Tree();           
                tree.root = new Node(1);                 //pre defined tree formation
                tree.root.left = new Node(2);
                tree.root.right = new Node(3);
                tree.root.left.left = new Node(4);
                tree.root.left.right = new Node(5);
                tree.root.right.left = new Node(6);
                Console.WriteLine("DFS InOrder traversal of binary tree is: ");
                tree.PrintInOrder(tree.root);
                Console.WriteLine("DFS PreOrder traversal of binary tree is: ");
                tree.PrintPreOrder(tree.root);
                Console.WriteLine("DFS PostOrder traversal of binary tree is: ");
                tree.PrintPostOrder(tree.root);

                Console.ReadKey();
            }
            catch(Exception e)        //catch block to catch any exception if it occurs
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
    class Node                       //node class that act as a structure for any node
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
