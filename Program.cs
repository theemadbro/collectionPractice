using System;
using System.Collections.Generic;

namespace collectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Arrays
            int[] arr1 = {0,1,2,3,4,5,6,7,8,9};
            string[] arr2 = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] arr3 = new bool[10];
            for (int i=0; i<arr3.Length; i+=2)
            {
                arr3[i] = true;
            }

            
            // Lists
            List<string> flavours = new List<string>();
            flavours.Add("vanilla");
            flavours.Add("chocolate");
            flavours.Add("birthday cake");
            flavours.Add("oreo");
            flavours.Add("cookie dough");
            System.Console.WriteLine(flavours.Count);
            System.Console.WriteLine(flavours[2]);
            flavours.RemoveAt(2);
            System.Console.WriteLine(flavours.Count);


            // Dictionaries
            Dictionary<string,string> dict = new Dictionary<string,string>();
            Random flav = new Random();
            for (int i=0; i<arr2.Length; i++)
            {
                dict.Add(arr2[i], flavours[flav.Next(0,3)]);
            }
            foreach (KeyValuePair<string,string> entry in dict)
            {
                System.Console.WriteLine(entry);
            }
        }
    }
}
