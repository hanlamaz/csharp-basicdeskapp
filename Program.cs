using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Decks mydesk = new Decks();
            mydesk.View();
            Console.WriteLine("");
            mydesk.Shuffle();
            mydesk.View();
            Console.WriteLine("");
            Console.WriteLine(mydesk.SelectUpperCard().ToString());
        }
    }
}
