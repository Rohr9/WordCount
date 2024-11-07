using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class WordCounter
    {
        public int WordOccurence(string text, string word)
        {
            int count = 0;
            string[] words = text.Split(' ', '.', ',', ';', ':', '!', '?', '\n', '\r');
            foreach (string w in words)
            {
                if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

