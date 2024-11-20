using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.String
{
    public class Anagram
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the first string:");
        //    string str1 = Console.ReadLine();

        //    Console.WriteLine("Enter the second string:");
        //    string str2 = Console.ReadLine();

        //    // Check if the strings are anagrams
        //    if (CheckAnagram(str1, str2))
        //    {
        //        Console.WriteLine("Strings are anagrams.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Strings are not anagrams.");
        //    }
        //}
        //static void SortArray(char[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i + 1; j < arr.Length; j++)
        //        {
        //            if (arr[i] > arr[j])
        //            {
        //                char temp = arr[i];
        //                arr[i] = arr[j];
        //                arr[j] = temp;
        //            }
        //        }
        //    }
        //}

        //static bool CheckAnagram(string str1, string str2)
        //{
        //    if (str1.Length != str2.Length)
        //        return false;

        //    char[] ch1 = new char[str1.Length];
        //    char[] ch2 = new char[str2.Length];

        //    for (int i = 0; i < str1.Length; i++)
        //    {
        //        ch1[i] = (str1[i] >= 'A' && str1[i] <= 'Z') ? (char)(str1[i] + 32) : str1[i];
        //        ch2[i] = (str2[i] >= 'A' && str2[i] <= 'Z') ? (char)(str2[i] + 32) : str2[i];
        //    }

        //    // Sort the character arrays manually
        //    SortArray(ch1);
        //    SortArray(ch2);

        //    // Compare the sorted arrays
        //    for (int i = 0; i < ch1.Length; i++)
        //    {
        //        if (ch1[i] != ch2[i])
        //            return false;
        //    }

        //    return true;
        //}
    }
}
