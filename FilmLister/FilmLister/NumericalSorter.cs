using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class NumericalSorter
    {
        public Queue<string> Sorter(Queue<string> needsSorting)
        {
            int a = needsSorting.Count;

            string[] setOfStrings = new string[a];

            string[] setOfStringsWithNumberFirst = new string[a];

            List<string> sortedList = new List<string>();

            int i = 0;

            foreach (string s in needsSorting)
            {
                foreach (char c in s)
                {
                    if (char.IsLetter(c))
                    {
                        setOfStrings[i] += c;
                    }
                    else if (char.IsDigit(c))
                    {
                        setOfStringsWithNumberFirst[i] += c;
                    }
                }

                setOfStringsWithNumberFirst[i] += setOfStrings[i];

                i++;
            }
            foreach (string s in setOfStringsWithNumberFirst)
            {

                sortedList.Add(s);

            }

            sortedList.Sort();

            Queue<string> sortedQueue = new Queue<string>(sortedList);

            return (sortedQueue);
        }
    }
}
