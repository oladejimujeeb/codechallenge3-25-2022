using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            Dictionary<string, int> wordDictionary = new Dictionary<string, int>() { };
            List<string> word = new List<string>() {"a","b", "c", "c", "c"};
            List<int> occurence = new List<int>();
            foreach (var item in word)
            {
                if (wordDictionary.ContainsKey(item))
                {
                    wordDictionary[item] = (int) wordDictionary[item]+1;
                }
                else
                {
                    wordDictionary.Add(item,1);
                }
            }

            foreach (var key in wordDictionary)
            {
                occurence.Add(key.Value);
            }

            for (int i = 0; i < occurence.Count-1; i++)
            {
                if (Math.Abs(occurence[i + 1] - occurence[i]) > 1)
                {
                    valid = true;
                   break;
                }
                
            }
            Console.WriteLine(valid);
        }
    }
}