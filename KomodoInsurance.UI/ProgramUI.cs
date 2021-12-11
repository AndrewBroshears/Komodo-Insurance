using KomodoInsurance.Repo;
using KomodoInsurance.POCO;
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
                case "1":
                    AddDevTeam();
                    break;
                case "2":
                    ViewDevTeam();
                    break;
                case "3":
                    AddDevTeamMember();
                    break;
                case "4":
                    RemoveDevTeamMember();
                    break;
                case "5":
                    DeleteDevTeam();
                    break;
                case "99":
                    runDevTeamMenu = false;
                    break;
                default:
                    Console.WriteLine("Try again.");
                    break;
            }
        }
        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Menu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateDeveloper();
                        break;
                    case "2":
                        GetDeveloperID();
                        break;
                    case "3":
                        UpdateDeveloper();
                        break;
                    case "4":
                        RemoveDeveloper();
                        break;
                    case "5":
                        Pluralsight();
                        break;
                    case "6":
                        DevTeamMenu();
                        break;
                    case "99":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.ReadLine();
                        break;

                }
            }
        }
        //CRUD
        private void CreateDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Please enter the Developer's First Name");
            string userInputFirstName = Console.ReadLine();
            Console.WriteLine("Please enter the Developer's Last Name");
            string userInputLastName = Console.ReadLine();
            Console.WriteLine("Does Developer have Pluralsight?");
            string userInputPlurasight = Console.ReadLine();
            bool hasPluralsight = false;
            if(userInputPlurasight == "y")
            {
                hasPluralsight = true;
            }
            DeveloperPoco CreateDeveloper = new DeveloperPoco(userInputFirstName, userInputLastName, 0, hasPluralsight);
            
        }
        private void GetDeveloperID()
        {
            Console.Clear();
            Console.WriteLine("Please enter Developer ID to find Developer");
            int getDeveloperID = int.Parse(Console.ReadLine());
            DeveloperPoco developer = _developerRepo.GetDeveloperById(getDeveloperID);

        }
        private void UpdateDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Enter the Developer's ID to Update");
        }
        private void RemoveDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Enter the Developer's ID to Remove Developer");
        }
        private void Pluralsight()
        {
            Console.Clear();
            Console.WriteLine("Enter the Developer's ID to view Pluralsight Access");
        }
        private void AddDevTeam()
        {
            Console.Clear();
            Console.WriteLine("Please enter Name of Team to Create");
        }
        private void ViewDevTeam()
        {
            Console.Clear();
            Console.WriteLine("List of Dev Teams:");
        }
        private void AddDevTeamMember()
        {
            Console.Clear();
            Console.WriteLine("Please enter the ID of the Developer you would like to add");
        }
        private void RemoveDevTeamMember()
        {
            Console.Clear();
            Console.WriteLine("Please enter the ID of the Developer you would like to remove");
        }
        private void DeleteDevTeam()
        {
            Console.Clear();
            Console.WriteLine("Please enter the Dev Team Name you would like to Delete");
        }
    }
}
