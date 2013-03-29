using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit;

namespace Tests.RemovingMovieTitlesFromExistingListFixtures
{
    [TestFixture]
    class When_removing_a_title_from_the_list_
    {
        [Test]
        public void should_check_validity_of_UI_and_remove_accordingly()
        {
            CheckAndRemove checkAndRemove = new CheckAndRemove();

            LinkedList<string> listWith3Nodes = new LinkedList<string>(); listWith3Nodes.AddFirst("A"); listWith3Nodes.AddFirst("B"); listWith3Nodes.AddFirst("C");

            LinkedList<string > listWith2Nodes = checkAndRemove.RemoveSpecifiedNode(listWith3Nodes, "C");

            Assert.AreNotEqual(listWith2Nodes.Count(), listWith3Nodes.Count());

        }
        public class CheckAndRemove
        {
            public LinkedList<string> RemoveSpecifiedNode(LinkedList<string> UnSorted, string UI)
            {
                if (UnSorted.Contains(UI))
                {
                    UnSorted.Remove(UI);

                    return (UnSorted);
                }
                else
                {
                    Console.WriteLine("That movie isn't on the list yet. Do you want to a>d<d it? Press any other key to continue.");

                    return (UnSorted);
                }
            }
        }

    }
}
