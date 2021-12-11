using KomodoInsurance.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.UI
{
    class ProgramUI
    {
        private readonly DeveloperRepo _developerRepo = new DeveloperRepo();
        private readonly DevTeamRepo _devTeamRepo = new DevTeamRepo();
        public void Run()
        {
            //seed();
            RunApplication();
        }
        public void Menu()
        {
            Console.WriteLine("Welcome to Komodo Insurance\n" +
                "1. Create a Developer\n" +
                "2. Find Developer ID\n" +
                "3. Update Developer\n" +
                "4. Remove Developer\n" +
                "5. Developers Pluralsight\n" +
                "6. Developer Teams Menu\n" +
                "99. Exit");
        }
        public void DevTeamMenu()
        {
            bool runDevTeamMenu = true;
            while (runDevTeamMenu)
            {
                Console.Clear();
                Console.WriteLine("Developer Teams Menu\n" +
                    "1. Create Developer Team\n" +
                    "2. View Developer Team\n" +
                    "3. Add Developer to Team\n" +
                    "4. Remove Developer from Team\n" +
                    "5. Remove Developer Team\n" +
                    "99. Return to Main Menu");
            }
            string userInput = Console.ReadLine();
            switch (userInput)
            {

            }
        }
    }
}
