using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tests.SortingFixtures;

namespace Tests.VariusFixtures
{
    class Tests_for_
    {
        public void Stack_in_LinkedList_functionality()
        {
            ToLinkedList();
        }
        public static LinkedList<Stack<string>> ToLinkedList()
        {
            
            Stack<string>[] HardCopyStackOne = new Stack<string>[3];
 
            HardCopyStackOne[0].Push("Title One"); HardCopyStackOne[0].Push("Actor One"); HardCopyStackOne[0].Push("Producer One");

            HardCopyStackOne[1].Push("Title Two"); HardCopyStackOne[1].Push("Actor Two"); HardCopyStackOne[1].Push("Producer Two");

            HardCopyStackOne[2].Push("Title Three"); HardCopyStackOne[2].Push("Actor three"); HardCopyStackOne[2].Push("Producer Three");

            HardCopyStackOne[3].Push("Title Four"); HardCopyStackOne[3].Push("Actor Four"); HardCopyStackOne[3].Push("Producer Four");

            LinkedList<Stack<string>> HardCopy = new LinkedList<Stack<string>>(); 

            Stack<string>[] setOfStacks = new Stack<string>[HardCopy.Count()];

            foreach(Stack<string> s in HardCopyStackOne)
            {
                HardCopy.AddFirst(s);
            }

            int x = 0;

            foreach (Stack<string> s in HardCopy)
            {
                setOfStacks[x] = s;
                x++;
            }



            

            return (HardCopy);
        }
    }
}
