using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests.SortingFixtures
{
    public class Sort
    {
        public LinkedList<string> AlphaSorter(LinkedList<string> needsSorting)
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

            LinkedList<string> SortedLL = new LinkedList<string>(sorted);

            return (SortedLL);
        }
        public LinkedList<string> NumberSorter(LinkedList<string> needsSorting)
        {
            int a = needsSorting.Count;

            string[] setOfStrings = new string[a];

            string[] setOfStringsWithNumberFirst = new string[a];

            List<string> sorted = new List<string>();

            int i = 0;

            foreach (string s in needsSorting)
            {
                foreach (char c in s)
                {
                    if (char.IsLetter(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c))
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

                sorted.Add(s);

            }


            sorted.Sort();

            LinkedList<string> SortedLL = new LinkedList<string>(sorted);

            return (SortedLL);
        }
        public LinkedList<string> DecideSortingMethod(bool alpha, bool numerical, LinkedList<string> needsToBeOrdered)
        {
            Sort sort = new Sort();
            if (alpha == true && numerical == false)
            {
                needsToBeOrdered = sort.AlphaSorter(needsToBeOrdered);
            }

            if (alpha == false && numerical == true)
            {
                needsToBeOrdered = sort.NumberSorter(needsToBeOrdered);
            }
            return (needsToBeOrdered);
        }
    }
}
