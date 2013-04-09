using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class HardCopyOfTitles
    {
        public static LinkedList<string> ToLinkedList()
        {
            LinkedList<string> HardCopy = new LinkedList<string>();

            HardCopy.AddFirst("The Lord of the Rings: The Return of the King 2003"); 
            HardCopy.AddFirst("Star Wars: Episode V - The Empire Strikes Back 1980"); 
            HardCopy.AddFirst("Saving Private Ryan 1998"); 
            HardCopy.AddFirst("Inside Man 2006"); 
            HardCopy.AddFirst("Source Code 2011");
            HardCopy.AddFirst("The Matrix 1999");
            HardCopy.AddFirst("The Wizard of Oz 1939");
            HardCopy.AddFirst("Star Wars 1977");
            HardCopy.AddFirst("Indiana Jones and the Last Crusade 1989");
            HardCopy.AddFirst("Toy Story 1995");
            HardCopy.AddFirst("Gran Torino 2008");
            HardCopy.AddFirst("V for Vendetta 2005");
            HardCopy.AddFirst("Pirates of the Caribbean: The Curse of the Black Pearl 2003");
            HardCopy.AddFirst("Jurassic Park 1993");
            HardCopy.AddFirst("Alien 1979");
            HardCopy.AddFirst("Megamind 2010");
            HardCopy.AddFirst("Battle Los Angeles 2011");
            HardCopy.AddFirst("Black Hawk Down 2001");

            return (HardCopy);
        }
        public static List<string> ToList()
        {
            LinkedList<string> HardCopy = new LinkedList<string>();

            HardCopy.AddFirst("The Lord of the Rings: The Return of the King 2003");
            HardCopy.AddFirst("Star Wars: Episode V - The Empire Strikes Back 1980");
            HardCopy.AddFirst("Saving Private Ryan 1998");
            HardCopy.AddFirst("Inside Man 2006");
            HardCopy.AddFirst("Source Code 2011");
            HardCopy.AddFirst("The Matrix 1999");
            HardCopy.AddFirst("The Wizard of Oz 1939");
            HardCopy.AddFirst("Star Wars 1977");
            HardCopy.AddFirst("Indiana Jones and the Last Crusade 1989");
            HardCopy.AddFirst("Toy Story 1995");
            HardCopy.AddFirst("Gran Torino 2008");
            HardCopy.AddFirst("V for Vendetta 2005");
            HardCopy.AddFirst("Pirates of the Caribbean: The Curse of the Black Pearl 2003");
            HardCopy.AddFirst("Jurassic Park 1993");
            HardCopy.AddFirst("Alien 1979");
            HardCopy.AddFirst("Megamind 2010");
            HardCopy.AddFirst("Battle Los Angeles 2011");
            HardCopy.AddFirst("Black Hawk Down 2001");

            List<string> HardCopyList = new List<string>(HardCopy);

            return (HardCopyList);
        }
        public static Queue<string> ToQueue()
        {
            LinkedList<string> HardCopy = new LinkedList<string>();

            HardCopy.AddFirst("The Lord of the Rings: The Return of the King 2003");
            HardCopy.AddFirst("Star Wars: Episode V - The Empire Strikes Back 1980");
            HardCopy.AddFirst("Saving Private Ryan 1998");
            HardCopy.AddFirst("Inside Man 2006");
            HardCopy.AddFirst("Source Code 2011");
            HardCopy.AddFirst("The Matrix 1999");
            HardCopy.AddFirst("The Wizard of Oz 1939");
            HardCopy.AddFirst("Star Wars 1977");
            HardCopy.AddFirst("Indiana Jones and the Last Crusade 1989");
            HardCopy.AddFirst("Toy Story 1995");
            HardCopy.AddFirst("Gran Torino 2008");
            HardCopy.AddFirst("V for Vendetta 2005");
            HardCopy.AddFirst("Pirates of the Caribbean: The Curse of the Black Pearl 2003");
            HardCopy.AddFirst("Jurassic Park 1993");
            HardCopy.AddFirst("Alien 1979");
            HardCopy.AddFirst("Megamind 2010");
            HardCopy.AddFirst("Battle Los Angeles 2011");
            HardCopy.AddFirst("Black Hawk Down 2001");

            Queue<string> HardCopyQueue = new Queue<string>(HardCopy);

            return (HardCopyQueue);
        }
        public static Stack<string> ToStack()
        {
            LinkedList<string> HardCopy = new LinkedList<string>();

            HardCopy.AddFirst("The Lord of the Rings: The Return of the King 2003");
            HardCopy.AddFirst("Star Wars: Episode V - The Empire Strikes Back 1980");
            HardCopy.AddFirst("Saving Private Ryan 1998");
            HardCopy.AddFirst("Inside Man 2006");
            HardCopy.AddFirst("Source Code 2011");
            HardCopy.AddFirst("The Matrix 1999");
            HardCopy.AddFirst("The Wizard of Oz 1939");
            HardCopy.AddFirst("Star Wars 1977");
            HardCopy.AddFirst("Indiana Jones and the Last Crusade 1989");
            HardCopy.AddFirst("Toy Story 1995");
            HardCopy.AddFirst("Gran Torino 2008");
            HardCopy.AddFirst("V for Vendetta 2005");
            HardCopy.AddFirst("Pirates of the Caribbean: The Curse of the Black Pearl 2003");
            HardCopy.AddFirst("Jurassic Park 1993");
            HardCopy.AddFirst("Alien 1979");
            HardCopy.AddFirst("Megamind 2010");
            HardCopy.AddFirst("Battle Los Angeles 2011");
            HardCopy.AddFirst("Black Hawk Down 2001");

            Stack<string> HardCopyStack  = new Stack<string>(HardCopy);

            return (HardCopyStack);
        }
        public static Stack<Stack<string>> StackOfStacks()
        {
            Stack<string> LordoftheRingsStack = new Stack<string>(); LordoftheRingsStack.Push("Producer One"); LordoftheRingsStack.Push("Actor One"); LordoftheRingsStack.Push("Title One");

            Stack<string> HardCopyStackOfStacksTwo = new Stack<string>(); HardCopyStackOfStacksTwo.Push("Producer Two"); HardCopyStackOfStacksTwo.Push("Actor Two"); HardCopyStackOfStacksTwo.Push("Title Two");

            Stack<string> HardCopyStackOfStacksThree = new Stack<string>(); HardCopyStackOfStacksThree.Push("Producer Three"); HardCopyStackOfStacksThree.Push("Actor three"); HardCopyStackOfStacksThree.Push("Title Three");

            Stack<string> HardCopyStackOfStacksFour = new Stack<string>(); HardCopyStackOfStacksFour.Push("Producer Four"); HardCopyStackOfStacksFour.Push("Actor Four"); HardCopyStackOfStacksFour.Push("Title Four");

            Stack<Stack<string>> HardCopyStackOfStacks = new Stack<Stack<string>>();

            HardCopyStackOfStacks.Push(HardCopyStackOfStacksFour);
            HardCopyStackOfStacks.Push(HardCopyStackOfStacksThree);
            HardCopyStackOfStacks.Push(HardCopyStackOfStacksTwo);
            HardCopyStackOfStacks.Push(LordoftheRingsStack);

            return (HardCopyStackOfStacks);
        }
    }
}
