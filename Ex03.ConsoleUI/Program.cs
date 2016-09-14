using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageManager garageMgr = new GarageManager();
            ConsoleUI ui = new ConsoleUI(garageMgr);

            ui.MainMenu();
        }
    }
}
