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
            Sort sort = new Sort();

            LinkedList<string> toBeSorted = new LinkedList<string>(); toBeSorted.AddFirst("decimal3"); toBeSorted.AddFirst("capital5"); toBeSorted.AddFirst("bee3"); toBeSorted.AddFirst("aligator9");

            toBeSorted = sort.AlphaSorter(toBeSorted);

            LinkedList<string> expected = new LinkedList<string>(); expected.AddFirst("aligator9"); expected.AddFirst("bee3"); expected.AddFirst("capital5"); expected.AddFirst("decimal3");

            Assert.AreEqual(expected, toBeSorted);

        }

    }
}
