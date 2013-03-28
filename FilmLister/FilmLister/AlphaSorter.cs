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

            string[] setOfNumbers = new string[a];

            string[] setOfStringsWithLetterFirst = new string[a];

            List<string> sorted = new List<string>();
                
            int i = 0;

            bool removesTheSpaceLeftoverByTheNumberSorter = false;

            foreach (string s in needsSorting)
            {
                removesTheSpaceLeftoverByTheNumberSorter = true;

                foreach (char c in s)
                {
                    if (char.IsDigit(c))
                    {
                        setOfNumbers[i] += c;
                    }
                    else if (c == ' ' && removesTheSpaceLeftoverByTheNumberSorter == true)
                    {
                        removesTheSpaceLeftoverByTheNumberSorter = true;
                    }
                    else if (char.IsLetter(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c) || c == ' ')
                    {
                        setOfStringsWithLetterFirst[i] += c;
                        removesTheSpaceLeftoverByTheNumberSorter = false;
                    }
                }

                setOfStringsWithLetterFirst[i] += setOfNumbers[i];

                i++;
            }
            foreach (string s in setOfStringsWithLetterFirst)
            {
                sorted.Add(s);
            }

            sorted.Sort();

            Queue<string> sortedQueue = new Queue<string>(sorted);

            return (sortedQueue);
        
        }
    }
}
