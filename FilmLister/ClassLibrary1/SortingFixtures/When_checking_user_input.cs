using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit;

namespace Tests.SortingFixtures
{
    [TestFixture]
    class When_checking_user_input_
    {
        [Test]
        public void should_eliminate_empty_inputs()
        {
            ChecknewItem checkNewItem = new ChecknewItem();

            String result = checkNewItem.CheckInput(" ");

            Assert.AreEqual(null, result);

        }
        public class ChecknewItem
        {
            public string CheckInput(string UI)
            {
                if (UI == "" || UI == " ")
                {
                    UI = null;
                    return (UI);
                }
                else { return (UI); }
            }
        }
    }
}
