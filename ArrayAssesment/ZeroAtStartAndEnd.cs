using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Arrays
{
    public class ZeroAtStartAndEnd
    {
        //***********************shifting 0 at first
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[5];

        //    Console.WriteLine("Enter 5 elements:");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = Convert.ToInt32(Console.ReadLine());
        //    }

        //    Console.WriteLine("Before shifting: " + string.Join(", ", arr));

        //    int pos = arr.Length - 1;

        //    for (int i = arr.Length - 1; i >= 0; i--)
        //    {
        //        if (arr[i] != 0)
        //        {
        //            arr[pos] = arr[i];
        //            pos--;
        //        }
        //    }

        //    while (pos >= 0)
        //    {
        //        arr[pos--] = 0;
        //    }

        //    Console.WriteLine("After shifting first: " + string.Join(", ", arr));
        //}

        //*********************shifting zero at last
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[5];
        //    Console.WriteLine("Enter elements:");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Console.WriteLine("Before shifting: " + string.Join(", ", arr));

        //    int pos = 0; 

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] != 0)
        //        {
        //            arr[pos] = arr[i];
        //            pos++;
        //        }
        //    }

        //    while (pos < arr.Length)
        //    {
        //        arr[pos++] = 0;
        //    }

        //    Console.WriteLine("After shifting at end: " + string.Join(", ", arr));
        //}
    }
}
