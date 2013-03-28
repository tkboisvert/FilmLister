using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication1;

namespace ConsoleApplication1
{
    public class ChecknewItem
    {
        public string CheckInput(string newItem)
        {
            if (newItem == "" || newItem == " ")
            {
                newItem = null;
                Console.WriteLine("You can't label a movie nothing!");
                Console.ReadLine();
                return (newItem);
            }
            else { return (newItem); }
        }
    }
}
