using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication1;


namespace ConsoleApplication1
{
    public class CheckString
    {
        public static LinkedList<string> AndAddSpecifiedNode(LinkedList<string> LinkedList, string UI)
        {
            if (UI == "" || UI == " ")
            {
                UI = null;
                Console.Clear();
                Console.WriteLine("You can't label something nothing!");
                Console.ReadKey();
                return (LinkedList);
            }
            else if (UI == null)
            {
                return (LinkedList);
            }
            else
            {
                LinkedList.AddFirst(UI);
                UI = null;
                return (LinkedList);
            }

        }
        public static LinkedList<string> AndRemoveSpecifiedNode(LinkedList<string> LinkedList, string UI)
        {
            if (LinkedList.Contains(UI))
            {
                LinkedList.Remove(UI);

                return (LinkedList);
            }
            else if (UI == null)
            {
                return (LinkedList);
            }
            else
            {
                UI = null;
                Console.Clear();
                Console.WriteLine("The movie you entered doesn't exist on this list.");
                Console.ReadKey();
                return (LinkedList);
            }
        }
    }
}
