using System;
using System.Collections.Generic;
using System.Text;
namespace HashTableProblem
{
    public class Frequency
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();
        public void WordFrequency(MyMapNode<int, string> hash)
        {
            for (int key = 0; key < hash.size; key++)
            {
                freq.TryAdd(hash.Get(key).ToLower(), 0);
                freq[hash.Get(key).ToLower()]++;
            }
            foreach (KeyValuePair<string, int> item in freq)
            {
                Console.WriteLine($"frequency of word '{item.Key}' is {item.Value}");
            }
        }
    }
}