
using System;

namespace Workshop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray_1 = { 123, 34, 189, 56, 150, 12, 9, 240 };
            int[] myArray_2 = { 92, 471, -49, 340, 286, 406, 127, 352, 407, 78, 225, 499, 224, 83, 269, -103, 356, 137, -187, 317, 495, 82, 409, 345, 483, -108, 100, 296, 52, 10, 327, 272};
            //ArrayOutput(myArray_1);
            bubblesort(myArray_1, 1);
            
            
            Console.WriteLine("Hello World!");
        }

        static void bubblesort(int[] a, int n)
        {
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1-i; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                       
                    }
                }
            }
        }

        static void ArrayOutput(int[] a)
        {
            foreach(var item in a)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void InsertionSort (int[] data)
        //pre: 0 <= n <= data.lenght
        //post: values in data[0 ... n-1] are in ascending order
        {
            //int numSorted = 1; //number of values in place
            //int index;
            //while ()
        }
  
    }
}
