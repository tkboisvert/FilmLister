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
            ToLinkedList();
        }
        public static Stack<Stack<string>> ToLinkedList()
        {
            Stack<string> HardCopyStackOfStacksOne = new Stack<string>(); HardCopyStackOfStacksOne.Push("Producer One"); HardCopyStackOfStacksOne.Push("Actor One"); HardCopyStackOfStacksOne.Push("Title One");

            Stack<string> HardCopyStackOfStacksTwo = new Stack<string>(); HardCopyStackOfStacksTwo.Push("Producer Two"); HardCopyStackOfStacksTwo.Push("Actor Two"); HardCopyStackOfStacksTwo.Push("Title Two");

            Stack<string> HardCopyStackOfStacksThree = new Stack<string>(); HardCopyStackOfStacksThree.Push("Producer Three"); HardCopyStackOfStacksThree.Push("Actor three"); HardCopyStackOfStacksThree.Push("Title Three");

            Stack<string> HardCopyStackOfStacksFour = new Stack<string>(); HardCopyStackOfStacksFour.Push("Producer Four"); HardCopyStackOfStacksFour.Push("Actor Four"); HardCopyStackOfStacksFour.Push("Title Four");

            Stack<Stack<string>> HardCopyStackOfStacks = new Stack<Stack<string>>();

            HardCopyStackOfStacks.Push(HardCopyStackOfStacksFour);
            HardCopyStackOfStacks.Push(HardCopyStackOfStacksThree);
            HardCopyStackOfStacks.Push(HardCopyStackOfStacksTwo);
            HardCopyStackOfStacks.Push(HardCopyStackOfStacksOne);

            Stack<string>[] setOfStacks = new Stack<string>[HardCopyStackOfStacks.Count()];

            int x = 0;

            foreach (Stack<string> s in HardCopyStackOfStacks)
            {
                setOfStacks[x] = s;
                x++;
            }
            x = 0;
            while (setOfStacks.Count() > x)
            {
                Console.WriteLine("{0}, {1}, {2}", setOfStacks[x].Pop(), setOfStacks[x].Pop(), setOfStacks[x].Pop());
                x++;
            }
            Console.Read();

            return (HardCopyStackOfStacks);
        }
    }
}