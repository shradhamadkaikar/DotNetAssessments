using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.String
{
    public class RepeatedWords
    {
        //public static void FindMostRepeated(string s)
        //{
        //    string[] words = s.Split(' ');  // Split the string into words
        //    int count;
        //    int maxCount = 0;
        //    string repeatedWords = "";

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        count = 0;
        //        for (int j = 0; j < words.Length; j++)
        //        {
        //            if (words[i].Equals(words[j], StringComparison.OrdinalIgnoreCase))  
        //            {
        //                if (i > j)  
        //                    break;
        //                count++;
        //            }
        //        }

        //        if (count > 0)
        //        {
        //            Console.WriteLine($"{words[i]}: {count}");
        //        }

        //        if (count > maxCount)
        //        {
        //            maxCount = count;
        //            repeatedWords = words[i];
        //        }
        //        else if (count == maxCount)
        //        {
        //            if (!repeatedWords.Contains(words[i]))
        //                repeatedWords += ", " + words[i];  // Add the word to the repeated list
        //        }
        //    }

        //    Console.WriteLine("Repeated word(s) is/are: " + repeatedWords + " -> " + maxCount);
        //}

        //static void Main(string[] args)
        //{
        //    string str = "Cat is mat and cat is eating rat and my cat is white";
        //    Console.WriteLine(str);
        //    FindMostRepeated(str);
        //}
    }
}
