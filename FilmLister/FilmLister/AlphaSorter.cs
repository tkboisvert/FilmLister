using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class AlphaSorter
    {
        public Queue<string> Sorter(Queue<string> needsSorting)
        {
            int a = needsSorting.Count;

            string[] setOfStrings = new string[a];

            List<string> sorted = new List<string>();
                
            int i = 0;

            foreach (string s in needsSorting)
            {
                foreach (char c in s)
                {
                    setOfStrings[i] += c;
                }
                i++;
            }
            foreach (string s in setOfStrings)
            {
                sorted.Add(s);
            }

            sorted.Sort();

            Queue<string> sortedQueue = new Queue<string>(sorted);

            return (sortedQueue);
        
        }
    }
}
