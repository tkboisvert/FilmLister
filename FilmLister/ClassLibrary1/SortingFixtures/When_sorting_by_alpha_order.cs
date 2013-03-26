using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit;

namespace Tests.SortingFixtures
{
    [TestFixture]
    class When_sorting_by_alpha_order
    {
        [Test]
        public void should_return_sorted_output()
        {
            AlphaSorter alphaSorter = new AlphaSorter();

            LinkedList<string> toBeSorted = new LinkedList<string>(); toBeSorted.AddFirst("decimal3"); toBeSorted.AddFirst("capital5"); toBeSorted.AddFirst("bee3"); toBeSorted.AddFirst("aligator9");

            List<string> result = alphaSorter.Sorter(toBeSorted);

            List<string> expected = new List<string>(); expected.Add("aligator9"); expected.Add("bee3"); expected.Add("capital5"); expected.Add("decimal3");

            Assert.AreEqual(expected, result);

        }

        internal class AlphaSorter
        {
            public List<string> Sorter(LinkedList<string> needsSorting)
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

                return (sorted);
            }
        }
    }
}
