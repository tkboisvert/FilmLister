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

            string[] numbers = new string[a];

            string[] space = new string[a];

            List<string> sortedList = new List<string>();

            int i = 0;

            foreach (string s in needsSorting)
            {
                bool removesDoubleSpaces = false;

                foreach (char c in s)
                {
                    if (char.IsLetter(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c))
                    {
                        if (char.IsWhiteSpace(c) && removesDoubleSpaces == false) { setOfStrings[i] += c; removesDoubleSpaces = true; }
                        else if (char.IsWhiteSpace(c) && removesDoubleSpaces == true){ removesDoubleSpaces = false; }
                        else { setOfStrings[i] += c; removesDoubleSpaces = false; }
                    }
                    else if (char.IsDigit(c))
                    {
                        numbers[i] += c;
                    }
                }
                numbers[i] += " ";
                numbers[i] += setOfStrings[i];

                i++;
            }
            foreach (string s in numbers)
            {

                sortedList.Add(s);

            }

            sortedList.Sort();

            Queue<string> sortedQueue = new Queue<string>(sortedList);

            return (sortedQueue);
        }
    }
}
