using System;
using System.Collections.Generic;
namespace StoreManagement
{
    internal class Program
    {
        static string[] branchName = new string[3];
        static string[] branchLocation = new string[3];

        static List<string> accesslogs = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("STORE BRANCH MANAGER\n");
            PopulateBranches();
            bool isRunning = true;

            while (isRunning){

                Console.WriteLine("1. Add a Branch");
                Console.WriteLine("2. View All Branches");
                Console.WriteLine("3. Update Branch Information");
                Console.WriteLine("4. Remove Branch");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter Choice (1 - 5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addBranch();
                        break;
                    case 2:
                        ViewBranch();
                    case 3:
                        UpdateBranch();
                        break;
                    case 4:
                        RemoveBranch();
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("Exiting the Program...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice. Please choose among the options (1 - 5)");
                        break;
                }
            }
            static void PopulateBranches() {
                branchName[0] = "Branch 0: Main Branch";
                branchLocation[0] = "Manila";

                branchName[1] = "Branch 1: North Branch";
                branchLocation[1] = "Baguio City";

                branchName[2] = "Branch 2: South Branch";
                branchLocation[2] = "Binan City";
            }

             static void addBranch()
                {
                    for (int i = 0; i < branchName.Length; i++)
                    {
                        if (branchName[i] == null)
                        {
                            Console.WriteLine("Enter desired Store Branch Name: ");
                            branchName[i] = Console.ReadLine();

                            Console.WriteLine("Enter Branch Location: ");
                            branchLocation[i] = Console.ReadLine();

                            Console.WriteLine("Branch Added Successfully!");
                            return;
                        }
                    }
                }
                
                static void ViewBranch() {
                    Console.WriteLine("BRANCH iNFORMATION\n");
                    for (int i = 0; i < branchName.Length; i++) {
                        if (branchName[i] == null) { 
                        }
                    }
                }

                static void UpdateBranch() {
                Console.WriteLine("Enter Branch No.: ");
                int index = Convert.ToInt32(Console.ReadLine());
            }
            static void RemoveBranch() { 
            Console.WriteLine("Enter Branch No. to Remove: ");
                int index = Convert.ToInt32(Console.ReadLine());

            }
        
    }
}
}
