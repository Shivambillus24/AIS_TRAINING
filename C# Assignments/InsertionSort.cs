using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.InsertionSort
{
    class Program
    {
        public static void InsertionSort(int[] array , int length)   //function to print the sorted list
        {
            int i;
            for(i=1;i<length;i++)
            {
                int j = i;
                while (j > 0)                             //loop to check till the first element of the array
                {
                    if (array[j - 1] > array[j])          //if the previous number is smaller swap them
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        j--;
                    }
                    else
                    {
                        j--;
                    }
                }

            }
            Console.WriteLine("The Sorted array is:");
            for (i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                int i, length;
                Console.WriteLine("Enter the length of the array: ");  
                length = Convert.ToInt32(Console.ReadLine());           //input the length of the array    
                if (length <= 0)
                {
                    Console.WriteLine("There can not be any sorting if the input length is 0:"); 
                }
                else
                {
                    Console.WriteLine("Enter the elements of the array:");
                    int[] array = new int[length];
                    for (i = 0; i < length; i++)
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());  //input the elements in the array

                    }
                    Program.InsertionSort(array, length);
                    Console.ReadKey();
                }    
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);       //print any exception if it occurs
            }
            Console.ReadKey();
        }
    }
}
