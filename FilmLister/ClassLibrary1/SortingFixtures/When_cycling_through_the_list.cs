using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace Tests.SortingFixtures
{
    [TestFixture]
    class When_cycling_through_the_list
    {
        [Test]
        public void should_factor_in_two_bools_and_decide_sorting_order()
        {
            Sort sort = new Sort();

            LinkedList<string> needsToBeOrdered = new LinkedList<string>(); needsToBeOrdered.AddFirst("A"); needsToBeOrdered.AddFirst("C"); needsToBeOrdered.AddFirst("B");

            LinkedList<string> inOrder = new LinkedList<string>(); inOrder.AddFirst("A"); inOrder.AddFirst("B"); inOrder.AddFirst("C");

            needsToBeOrdered = sort.DecideSortingMethod(true, false, needsToBeOrdered);

            Assert.AreEqual(inOrder, needsToBeOrdered);

        }
    }
}
