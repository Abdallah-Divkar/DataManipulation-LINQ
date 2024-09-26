using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Abdallah_Divkar_Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dictionary = CollectWords();
            DisplayDictionary(dictionary);
            DisplayDuplicate(dictionary);
        }

        private static SortedDictionary<string, int> CollectWords()
        {
            var dictionary = new SortedDictionary<string, int>();

            Console.WriteLine("Enter a string: "); // prompt for user input
            string input = Console.ReadLine(); // get input

            string[] words = Regex.Split(input, @"\s+");

            foreach (var word in words)
            {
                var key = word.ToLower(); // convert to lowercase

                if (dictionary.ContainsKey(key))
                {
                    ++dictionary[key];
                }
                else
                {
                    dictionary.Add(key, 1);
                }
            }

            return dictionary;
        }

        // display dictionary content
        private static void DisplayDictionary<K, V>(SortedDictionary<K, V> dictionary)
        {
            Console.WriteLine($"\nSorted dictionary contains:\n{"Key",-12}{"Value",-12}");

            // generate output for each key in the sorted dictionary
            // by iterating through the Keys property with a foreach statement
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key,-12}{dictionary[key],-12}");
            }

            Console.WriteLine($"\nsize: {dictionary.Count}");
        }

        private static void DisplayDuplicate(SortedDictionary<string, int> dictionary)
        {
            Console.Write($"\nDuplicates:");
            foreach(var pair in dictionary.Where(x => x.Value > 1))
            {
                Console.Write($" {pair.Key},");
            }
            Console.WriteLine();
        }
    }
}
