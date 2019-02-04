using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Queue
{
    class Program
    {
        private int rear,maxSize,front;                   
        public void Push(int[] myQueue,int j)                   //function to push into queue
        {
            rear = rear + 1;
            if (rear > maxSize - 1)                             //to check if queue is full or not
            {
                Console.WriteLine("Queue is full!");
            }
            else
            {
                myQueue[rear] = j;
            }
        }
        public void Pop(int[] myQueue)                        //function to pop from queue
        {
            if (rear < front)                                 //condition to check if queue is empty or not
            {
                Console.WriteLine("Queue is Empty!");
            }
            else
            {
                front = front + 1;
            }
        }
        public void PrintElements(int[] myQueue)
        {
            if (rear < front)                                     //condition to check if queue is empty or not
            {
                Console.WriteLine("Queue is Empty!");
            }
            else
            {
                int i;
                Console.WriteLine("The elements in the Queue are:");
                Console.WriteLine(front);
                Console.WriteLine(rear);
                for (i = front; i <= rear; i++)
                {
                    Console.WriteLine(myQueue[i]);               //printing the elements in the queue
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                char answer = 'y';
                Program p = new Program();
                p.rear = -1;                                    //initializing rear variable
                p.front = 0;                                    //initializing front variable
                Console.WriteLine("Enter the max size of the Queue: ");
                p.maxSize = Convert.ToInt32(Console.ReadLine());   //inputing the max size of the queue from user
                int[] myQueue = new int[p.maxSize];
                while (answer == 'y')
                {
                    int action;
                    Console.WriteLine("Press 1 to add element in the Queue");
                    Console.WriteLine("Press 2 to pop element from the Queue");
                    Console.WriteLine("Press 3 to print all the elements in the Queue");
                    action = Convert.ToInt32(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            {
                                int j;
                                Console.WriteLine("Enter the element you want to add:");
                                j = Convert.ToInt32(Console.ReadLine());
                                p.Push(myQueue, j);
                                break;
                            }
                        case 2:
                            {
                                p.Pop(myQueue);
                                break;
                            }
                        case 3:
                            {
                                p.PrintElements(myQueue);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Please enter a valid choice:");
                                break;
                            }

                    }
                    Console.WriteLine("If you want to continue press y else n:");
                    answer = Convert.ToChar(Console.ReadLine());
                }
            }
            catch(Exception e)                 //catch block to check if there is any exception or not
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }


        }
    }
}
