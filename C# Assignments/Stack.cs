using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Stack
{

    class Program
    {
        private int top,maxSize;
        public void Push(int[] myStack,int j)      //push function to push elements in the stack
        {
            if (top == maxSize - 1)                //condition to check if the stack is full or not
            {
                Console.WriteLine("The stack is full!");
            }
            else
            {
                top = top + 1;
                myStack[top] = j;                   //pushing the element in the stack
            }
        }
        public void Pop(int[] myStack)              //function to pop element from stack
        {
            if (top == -1)                           //condition to check if stack is empty or not
            {
                Console.WriteLine("The stack is empty:");
            }
            else
            {
                top--;
            }
        }
        public void PrintElements(int[] myStack)
        {
            int i;
            if (top == -1)
            {
                Console.WriteLine("The stack is empty:");
            }
            else
            {
                Console.WriteLine("The stack elements are:");
                for (i = 0; i <= top; i++)
                {
                    Console.WriteLine(myStack[i]);               //printing the elements in stack
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Program p = new Program();
                int action;
                p.top = -1;
                char answer = 'y';
                Console.WriteLine("Enter the max size of stack:");
                p.maxSize = Convert.ToInt32(Console.ReadLine());
                if (p.maxSize <= 0)              //condition to check if the user input is valid or not
                {
                    Console.WriteLine("Stack of desired size can not be possible!");
                    Console.ReadKey();
                }
                else
                {
                    int[] myStack = new int[p.maxSize];
                    while (answer == 'y')
                    {
                        Console.WriteLine("To push into stack press 1:");
                        Console.WriteLine("To pop from stack press 2:");
                        Console.WriteLine("To print all the elements in stack press 3:");
                        action = Convert.ToInt32(Console.ReadLine());
                        switch (action)
                        {
                            case 1:
                                {
                                    int j;
                                    Console.WriteLine("Enter the element you want to push:");
                                    j = Convert.ToInt32(Console.ReadLine());
                                    p.Push(myStack, j);
                                    break;
                                }
                            case 2:
                                {
                                    p.Pop(myStack);
                                    break;

                                }
                            case 3:
                                {
                                    p.PrintElements(myStack);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("please enter a valid choice:");
                                    break;
                                }
                        }
                        Console.WriteLine("If you want to repeat press y if not press n:");
                        answer = Convert.ToChar(Console.ReadLine());
                    }
                }
            }
            catch(Exception e)                    //catch block if there is any exception or not
            {
                Console.WriteLine(e.Message);       
                Console.Read();
            }



        }
    }
}
