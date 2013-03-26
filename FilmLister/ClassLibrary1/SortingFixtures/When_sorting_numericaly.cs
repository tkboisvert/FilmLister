using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit;

namespace Tests.SortingFixtures
{
    [TestFixture]
    class When_sorting_numericaly
    {
        [Test]
        public void Should_sort_strings_to_numerical_order()
        {
            NumberSorter numberSorter = new NumberSorter();

            LinkedList<string> toBeSorted = new LinkedList<string>(); toBeSorted.AddFirst("decimal 1994"); toBeSorted.AddFirst("capital 1999"); toBeSorted.AddFirst("bee 2000"); toBeSorted.AddFirst("aligator 1817");

            List<string> result = numberSorter.Sorter(toBeSorted);

            List<string> expected = new List<string>(); expected.Add("1817aligator"); expected.Add("1994decimal"); expected.Add("1999capital"); expected.Add("2000bee"); expected.Sort();

            Assert.AreEqual(expected, result);

        }

        internal class NumberSorter
        {
            public List<string> Sorter(LinkedList<string> needsSorting)
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

                return(sortedList);
            }
        }
    }
}
