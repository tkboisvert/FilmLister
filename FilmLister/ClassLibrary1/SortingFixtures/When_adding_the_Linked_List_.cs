using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit;

namespace Tests.SortingFixtures
{
    [TestFixture]
    class When_adding_the_Linked_List_
    {
        [Test]
        public void should_check_if_null_and_add_to_the_string_accordingly()
        {
            CheckNewItem checkNewItem = new CheckNewItem();

            string result = checkNewItem.Add("hello world");

            Assert.AreEqual("hello world", result);
        }
        public class CheckNewItem
        {
            public string Add(string UI)
            {
                if (UI != null)
                {
                    return (UI);
                }
                else
                {
                    UI = null;
                    return (UI);
                }
            }
        }

    }
}
