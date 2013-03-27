using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string newItem = null;

            bool alpha = true;

            bool numerical = false;

            Queue<string> StartingSetOfStrings = new Queue<string>(); StartingSetOfStrings.Enqueue("z1"); StartingSetOfStrings.Enqueue("y2"); StartingSetOfStrings.Enqueue("x3"); StartingSetOfStrings.Enqueue("w4"); StartingSetOfStrings.Enqueue("v5"); StartingSetOfStrings.Enqueue("u6");

            Queue<string> forNavigationalUse = new Queue<string>(); forNavigationalUse.Enqueue("z1"); forNavigationalUse.Enqueue("y2"); forNavigationalUse.Enqueue("x3"); forNavigationalUse.Enqueue("w4"); forNavigationalUse.Enqueue("v5"); forNavigationalUse.Enqueue("u6");


            while (true)
            {

                if (newItem != null)
                {
                    StartingSetOfStrings.Enqueue(newItem);
                    forNavigationalUse.Enqueue(newItem);
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
                Console.WriteLine("Press the left or right arrow keys to navigate");
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
                        if (i < (forNavigationalUse.Count() - 1))
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
                }

            }
            //public class Recount
            //{
            //    public string[] Count(string UI)
            //    {
            //        foreach (string s in StartingSetOfStrings)
            //        {
            //            foreach (char c in s)
            //            {
            //                setOfStrings[x] += c;
            //            }
            //            x++;
            //        }
            //    }
            //}
        }
    }
}

