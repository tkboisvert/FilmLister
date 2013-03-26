using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Tests.AddingAdditionalMovieTitlesFixtures
{
    [TestFixture]
    class When_a_new_instance_of_AddMovie_is_started_
    {
        [Test]
        public void should_add_the_users_input_to_list()
        {
            AddMovie addMovie = new AddMovie();

            bool shouldBeTrue = addMovie.AddToList(Console.ReadLine());

            Assert.AreEqual(true, shouldBeTrue);
        }

        internal class AddMovie
        {
            public bool AddToList(string UI)
            {
                bool shouldBeTrue = false;

                List<string> firstList = new List<string>(); firstList.Add("Intelligence"); firstList.Add("Spelunking"); firstList.Add("book");

                int x = firstList.Count();

                firstList.Add(UI);

                int y = firstList.Count();

                if (x < y)
                {
                    shouldBeTrue = true;
                }

                return (shouldBeTrue);
            }
        }
    }
}
