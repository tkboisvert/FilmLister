﻿using System;
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
    }
}