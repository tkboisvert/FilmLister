﻿using System;
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
            string newItem = null;

            bool alpha = true;

            bool numerical = false;

            Queue<string> StartingSetOfStrings = new Queue<string>(); StartingSetOfStrings.Enqueue("The Lord of the Rings: The Return of the King 2003"); StartingSetOfStrings.Enqueue("Star Wars: Episode V - The Empire Strikes Back 1980"); StartingSetOfStrings.Enqueue("Saving Private Ryan 1998"); StartingSetOfStrings.Enqueue("Inside Man 2006"); StartingSetOfStrings.Enqueue("Source Code 2011"); StartingSetOfStrings.Enqueue("The Matrix 1999");

            while (true)
            {
                ChecknewItem checknewItem = new ChecknewItem();

                newItem = checknewItem.CheckInput(newItem);

                if (newItem != null)
                {
                StartingSetOfStrings.Enqueue(newItem);
                newItem = null;
                }

                if (alpha == true && numerical == false) 
                {
                    AlphaSorter alphaSorter = new AlphaSorter();

                    StartingSetOfStrings = alphaSorter.Sorter(StartingSetOfStrings);
                }

                if (alpha == false && numerical == true)
                {
                    NumericalSorter numericalSorter = new NumericalSorter();

                    StartingSetOfStrings = numericalSorter.Sorter(StartingSetOfStrings);
                }

                string[] setOfStrings = new string[StartingSetOfStrings.Count()];

                Console.Clear();
                Console.WriteLine("Sort by: >Y<ear, >A<lphabetical");
                Console.WriteLine("");
                Console.WriteLine("Press the left or right arrow keys to navigate/begin");
                Console.WriteLine("");
                Console.WriteLine("A>d<d title");
                Console.WriteLine("<-          ->");

                int i = -1;

                int x = 0;

                foreach (string s in StartingSetOfStrings)
                {
                    foreach (char c in s)
                    {
                        setOfStrings[x] += c;
                    }
                    x++;
                }

                while (true)
                {

                    ConsoleKeyInfo keyInfo = Console.ReadKey();


                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        if (i < (StartingSetOfStrings.Count() - 1))
                        {
                            i++;
                            Console.Clear();
                            Console.WriteLine("Sort by: >Y<ear, >A<lphabetical");
                            Console.WriteLine("");
                            Console.WriteLine(setOfStrings[i]);
                            Console.WriteLine("");
                            Console.WriteLine("A>d<d title");
                            if (StartingSetOfStrings.First() == setOfStrings[i])
                            {
                                Console.WriteLine("            ->");
                            }
                            else if (StartingSetOfStrings.Last() == setOfStrings[i])
                            {
                                Console.WriteLine("<-            ");
                            }
                            else
                            {
                                Console.WriteLine("<-          ->");
                            }
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        if (i >= 1)
                        {
                            i--;
                            Console.Clear();
                            Console.WriteLine("Sort by: >Y<ear, >A<lphabetical");
                            Console.WriteLine("");
                            Console.WriteLine(setOfStrings[i]);
                            Console.WriteLine("");
                            Console.WriteLine("A>d<d title");
                            if (StartingSetOfStrings.First() == setOfStrings[i])
                            {
                                Console.WriteLine("            ->");
                            }
                            else if (StartingSetOfStrings.Last() == setOfStrings[i])
                            {
                                Console.WriteLine("<-            ");
                            }
                            else
                            {
                                Console.WriteLine("<-          ->");
                            }


                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        numerical = true;
                        alpha = false;
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.A)
                    {
                        Console.Clear();
                        numerical = false;
                        alpha = true;
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the new movie with Year");
                        Console.WriteLine("Example: New Movie One 1996");
                        newItem = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid key");
                    }
                }

            }
        }
    }
}

