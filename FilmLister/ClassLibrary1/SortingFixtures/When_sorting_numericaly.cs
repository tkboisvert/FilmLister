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
            Sort sort = new Sort();

            LinkedList<string> toBeSorted = new LinkedList<string>(); toBeSorted.AddFirst("decimal 1994"); toBeSorted.AddFirst("capital 1999"); toBeSorted.AddFirst("bee 2000"); toBeSorted.AddFirst("aligator 1817");

            List<string> sortedList = new List<string>(); sortedList.Add("1817aligator"); sortedList.Add("1994decimal"); sortedList.Add("1999capital"); sortedList.Add("2000bee"); sortedList.Sort();

            LinkedList<string> result = sort.NumberSorter(toBeSorted);

            LinkedList<string> expected = new LinkedList<string>(sortedList);

            Assert.AreEqual(expected, result);

        }
    }
}
