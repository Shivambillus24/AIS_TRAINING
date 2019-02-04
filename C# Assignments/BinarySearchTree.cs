using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.BinarySearchTree
{
    class BST
    {
        public Node root;         
        public void PrintTree(Node root)    //function to print the elements of tree
        {
            if (root == null)
            {
                return;
            }
            else
            {
                PrintTree(root.left);
                Console.WriteLine(root.data);
                PrintTree(root.right);
            }
        }
        public void Insert(int d)        //function to insert data in the tree
        {
            Node newNode = new Node();
            newNode.data = d;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root; 
                Node parent;
                while (true)
                {
                    parent = current;
                    if (d < current.data)    //if data entered is less then root then go left of root
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else                    //else go right of the root
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }

                }


            }
        }       
        public static void Main(string[] args)
        {
            try
            {
                char answer = 'y';
                BST b = new BST();
                while (answer=='y')               //while loop till the user enter n for no
                {
                    int d;
                    Console.WriteLine("Enter the number you want to add in the tree:");
                    d = Convert.ToInt32(Console.ReadLine());      //input the data user want to enter in tree
                    b.Insert(d);
                    Console.WriteLine("If you want to enter more press y else press n:");
                    answer = Convert.ToChar(Console.ReadLine());

                }
                Console.WriteLine("The tree InOrder traversal is:");
                b.PrintTree(b.root);
                Console.ReadKey();
            }
            catch(Exception e)        //catch block to catch any exception
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
    class Node                  //node class that acts as a structure for any node
    {
        public int data;
        public Node left;
        public Node right;
    }
}
