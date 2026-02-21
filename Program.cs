namespace StoreManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STORE BRANCH MANAGER\n");

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

                case 2:

                case 3:
                    UpdateBranch();
                case 4:


            }

            static void UpdateBranch() { 
            Console.WriteLine("ENTER BRANCH INFORMATION\n");

            Console.WriteLine("Enter Store Branch Name: ");
            string branchName = Console.ReadLine();

            Console.WriteLine("Enter Branch Location: ");
            string branchLoc = Console.ReadLine();

            Console.WriteLine("Enter Branch No.: ");
            int sales = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
