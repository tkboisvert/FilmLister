using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication1;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

            string stringForAddingToTheList = null;

            string stringForRemovingFromTheList = null;

            string sortedBy = "Defaulted to alphabetical";

            bool alpha = true;

            bool numerical = false;

            int x = 0;

            LinkedList<string> StartingSetOfStrings = new LinkedList<string>(HardCopyOfTitles.ToLinkedList());

            while (true)
            {
                
                StartingSetOfStrings = CheckString.AndAddSpecifiedNode(StartingSetOfStrings, stringForAddingToTheList);

                StartingSetOfStrings = CheckString.AndRemoveSpecifiedNode(StartingSetOfStrings, stringForRemovingFromTheList);

                stringForAddingToTheList = null;

                stringForRemovingFromTheList = null;

                StartingSetOfStrings = Sort.DecideSortingMethod(alpha, numerical, StartingSetOfStrings);

                string[] setOfStrings = new string[StartingSetOfStrings.Count()];

                // Initial menu, any changes to the list will result in re-starting to this output

                Console.Clear();
                Console.WriteLine(sortedBy);
                Console.WriteLine("Sort by: (Y)ear, (A)lphabetical");
                Console.WriteLine("");
                Console.WriteLine("Press the right arrow key to begin");
                Console.WriteLine("");
                Console.WriteLine("a(D)d a title, (R)emove a title, (L)ist all");
                if (sortedBy == "Sorting: by year" || sortedBy == "Sorting: alphabeticaly") // Sets the proper arrow config 
                {
                    Console.WriteLine("            ->");
                }
                else { Console.WriteLine("<-          ->"); }

                x = 0;

                foreach (string s in StartingSetOfStrings)
                {
                    setOfStrings[x] = s;
                    x++;
                }

                x = -1;

                while (true)
                {

                    keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.RightArrow) // Changes output to the proceding entry in StartingSetOfStrings
                    {
                        if (x < (StartingSetOfStrings.Count() - 1))
                        {
                            x++;
                            Console.Clear();
                            Console.WriteLine(sortedBy);
                            Console.WriteLine("Sort by: (Y)ear, (A)lphabetical");
                            Console.WriteLine("");
                            Console.WriteLine(setOfStrings[x]);
                            Console.WriteLine("");
                            Console.WriteLine("a(D)d a title, (R)emove a title, (L)ist all");
                            if (StartingSetOfStrings.First() == setOfStrings[x])
                            {
                                Console.WriteLine("            ->");
                            }
                            else if (StartingSetOfStrings.Last() == setOfStrings[x])
                            {
                                Console.WriteLine("<-            ");
                            }
                            else
                            {
                                Console.WriteLine("<-          ->");
                            }
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.LeftArrow) // Changes output to the previous entry in StartingSetOfStrings
                    {
                        if (x >= 1)
                        {
                            x--;
                            Console.Clear();
                            Console.WriteLine(sortedBy);
                            Console.WriteLine("Sort by: (Y)ear, (A)lphabetical");
                            Console.WriteLine("");
                            Console.WriteLine(setOfStrings[x]);
                            Console.WriteLine("");
                            Console.WriteLine("a(D)d a title, (R)emove a title, (L)ist all");
                            if (StartingSetOfStrings.First() == setOfStrings[x])
                            {
                                Console.WriteLine("            ->");
                            }
                            else if (StartingSetOfStrings.Last() == setOfStrings[x])
                            {
                                Console.WriteLine("<-            ");
                            }
                            else
                            {
                                Console.WriteLine("<-          ->");
                            }


                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.Y) // Sorts StartingSetOfStrings by year
                    {
                        Console.Clear();
                        sortedBy = "Sorting: by year";
                        numerical = true;
                        alpha = false;
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.A) // Sorts StartingSetOfStrings alphabeticaly
                    {
                        Console.Clear();
                        sortedBy = "Sorting: alphabeticaly";
                        numerical = false;
                        alpha = true;
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.D) // Add a title to StartingSetOfStrings
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the new movie with Year");
                        Console.WriteLine("Example: New Movie One 1996");
                        stringForAddingToTheList = Console.ReadLine();
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.R) // Lists all titles and removes a specified title from StartingSetOfStrings
                    {
                        Console.Clear();
                        Console.WriteLine("Type the name of the movie and coresponding year");
                        Console.WriteLine("");
                        Console.WriteLine("If you've changed your mind, press the escape key.");
                        Console.WriteLine("");
                        Sort.ListAll(StartingSetOfStrings);
                        Console.WriteLine("");
                        Console.WriteLine("Text must be formatted in the same way, with the same case.");
                        keyInfo = Console.ReadKey();

                        if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            stringForRemovingFromTheList = null;
                        }

                        else 
                        { 
                            string firstCharacter = keyInfo.Key.ToString();
                            stringForRemovingFromTheList = firstCharacter += Console.ReadLine();
                        }

                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.L) // Lists all movie titles that are currently in StartingSetOfStrings
                    {
                        Console.Clear();
                        Sort.ListAll(StartingSetOfStrings);
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" is not a valid key"); // keyInfo.Key precedes this string. 
                    }
                }
            }
        }
    }
}

