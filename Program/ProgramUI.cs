using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevRepoPtoject;
using static DevRepoPtoject.DevelopersRepository;

namespace Program
{
    class ProgramUI
    {
        private readonly DevelopersRepo _DeveloperRepo = new DevelopersRepo();
        private readonly DevelopersTeamRepository _DevTeamRepo = new DevelopersTeamRepository();
        public void Run()
        {
            SeedDevList();
            Menu();
        }


        private void Menu()
        {
            bool keepRunning = true;
            while (keeprunning)
            {
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add a Developer\n" +
                    "2. View current developers\n" +
                    "3. View by ID\n" +
                    "4. Update a Developer\n" +
                    "5. Delete a Developer\n" +
                    "6. Build a Developer Team\n" +
                    "7. View all Developer Teams\n" +
                    "8. View Team by ID\n" +
                    "9. Update a Developer Team\n" +
                    "10. Delete a team\n" +
                    "11. Add a Developer to a Team\n" +
                    "12. Remove a Devloper from a Team\n" +
                    "13. Close Application");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                       
                        AddNewDev();
                        break;
                    case "2":
                        
                        DisplayAllDevs();
                        break;
                    case "3":
                       
                        DisplayDevsByID();
                        break;
                    case "4":
                        
                        UpdateExistingDev();
                        break;
                    case "5":
                        
                        DeleteExistingDev();
                        break;
                    case "6":
                        
                        AddNewDevTeam();
                        break;
                    case "7":
                       
                        DisplayAllDevTeams();
                        break;
                    case "8":
                        
                        DisplayDevTeamsByID();
                        break;
                    case "9":
                       
                        UpdateExistingDevTeam();
                        break;
                    case "10":
                        
                        DeleteExistingDevTeam();
                        break;
                    case "11":
                        
                        AddNewDevTeamMember();
                        break;
                    case "12":
                      
                        RemoveNewDevTeamMember();
                        break;
                    case "13":
                      
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        }

        private void SeedDevList()
        {
            Developers john = new Developers("John Pheobus", "1", true);
        }
    }
}
