using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Sort
    {
        public static LinkedList<string> DecideSortingMethod(bool alpha, bool numerical, LinkedList<string> needsToBeOrdered)
        {
            if (alpha == true && numerical == false)
            {
                needsToBeOrdered = Sort.ByAlpha(needsToBeOrdered);
            }

            if (alpha == false && numerical == true)
            {
                needsToBeOrdered = Sort.ByNumber(needsToBeOrdered);
            }
            return (needsToBeOrdered);
        }

        public static LinkedList<string> ByAlpha(LinkedList<string> needsSorting)
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

            LinkedList<string> sortedLinkedList = new LinkedList<string>(sorted);

            return (sortedLinkedList);
        
        }

        public static LinkedList<string> ByNumber(LinkedList<string> needsSorting)
        {
            int a = needsSorting.Count;

            string[] setOfStrings = new string[a];

            string[] numbers = new string[a];

            string[] space = new string[a];

            List<string> sortedList = new List<string>();

            int i = 0;

            foreach (string s in needsSorting)
            {
                bool removesDoubleSpaces = true;

                foreach (char c in s)
                {
                    if (char.IsLetter(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c))
                    {
                        if (char.IsWhiteSpace(c) && removesDoubleSpaces == false) { setOfStrings[i] += c; removesDoubleSpaces = true; }
                        else if (char.IsWhiteSpace(c) && removesDoubleSpaces == true) { removesDoubleSpaces = false; }
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

            LinkedList<string> sortedLinkedList = new LinkedList<string>(sortedList);

            return (sortedLinkedList);
        }
        public static void ListAll(LinkedList<string> ListOfTitles)
        {
            foreach (string s in ListOfTitles)
            {
                Console.WriteLine(s);
            }
        }
    }
}
