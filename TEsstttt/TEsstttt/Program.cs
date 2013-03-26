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
        static void Main(string[] args)
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
