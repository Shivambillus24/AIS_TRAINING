using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.MergeSort
{
    class Program
    {
        public void MergeSort(int[] array, int start, int end)      //Mergesort function 
        {
            int mid;
            if (start < end)
            {
                mid = (start + end) / 2;
                MergeSort(array, start, mid);
                MergeSort(array, mid + 1, end);
                Merge(array, start, mid, end);
            }

        }
        public void Merge(int[] array, int start,int mid,int end)   //merge function
        {
            int n1 = mid - start + 1;                //length of left part of the divided array
            int n2 = end - mid;                      //length of the right part of the divided array
            int[] left = new int[n1];
            int[] right = new int[n2];
            int i, j, k;
            for (i = 0; i < n1; i++)
            {
                left[i] = array[start+i];                 //initializing left array
            }
            for (j = 0; j < n2; j++)
            {
                right[j] = array[mid + 1 + j];           //initializing right array
            }
            i = 0;
            j = 0;
            k = start;
            while(i<n1 && j < n2)                //merging the two left and right array
            {
                if (left[i] < right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)                     //while loop if only left array has elements
            {
                array[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)                     //while loop if only right array has elements
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }
        public void PrintSortedArray(int[] array,int size)    //function to print the sorted array
        {
            int i;
            Console.WriteLine("The sorted array is:");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                int i;
                Program p = new Program();
                Console.WriteLine("Enter the length of the array you want to sort:");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];
                Console.WriteLine("Enter the numbers in the array:");
                for (i = 0; i < size; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                p.MergeSort(array, 0, size - 1);
                p.PrintSortedArray(array, size);
                Console.ReadKey();
            }
            catch(Exception e)                     //catch block to catch any exception if it occurs
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
