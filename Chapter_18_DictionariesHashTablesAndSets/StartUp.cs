using System;
using Utilities;
using Utilities.Contracts;

namespace Chapter_18_DictionariesHashTablesAndSets
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu();
            menu.Display();
        }
    }
}