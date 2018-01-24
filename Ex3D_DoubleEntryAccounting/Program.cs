using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3D_DoubleEntryAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
                var exitProgram = false;

                //display the menu for the user till they press 0 to exit program
                do
                {
                    //Call method for user to select choice from menu and return thier selection
                    //Place int value of selected i tem in the parameter of what to do with it
                    //if entered 0, boolean changes to true and program exits

                    exitProgram = actOnSelectedItem(selectMainMenuItem());
                    
                //as long as user hasn't entered 0 program remains running
                } while (!exitProgram);
            }



            //Method to show a menu of reports available and return which one is selected
            //continue to use item 1 as return to main menu
            //What are some standard reports needed?  
            //Balance Sheet (Assets=Liabilities + Capitol)
            //Income Statement (Revenue Expenses Gains Losses)
            //Equity Statment (Equity changes)            

            //Method to compile individual reports (each?)
        }
        //Method to enter a transaction, 
        //as a stretch goal - be able to split a transation between accounts
        //after last item is entered for entry, ask to save transaction or discard
        //if saved, push transaction to database
        //ask user to "enter 1 for main menu" and "enter 2 for another transaction"

        static void enterTransaction()
        {
            int i = 0;
            int n = 1;
            Console.Clear();
            Console.WriteLine("Enter your transaction details:\n");

            for (i = 0; i <= 5; i++)
            {
                switch (n)
                {
                    case 1:
                        Console.Write("Date: ");
                        string date = Console.ReadLine();
                        n = 2;
                        break;
                    case 2:
                        Console.Write("Description: ");
                        string description = Console.ReadLine();
                        n = 3;
                        break;
                    case 3:
                        Console.Write("Amount: $");
                        double amount = double.Parse(Console.ReadLine());
                        n = 4;
                        break;
                    case 4:
                        Console.Write("Account Credited: ");
                        string acctCredit = Console.ReadLine(); 
                        n = 5;
                        break;
                    case 5:
                        Console.Write("Account Debited: ");
                        string acctDebit = Console.ReadLine();
                        n = 6;
                        break;
                }
            }
            //Do something here at the end of the for loop
        }


        //Method to View Account Listing for further selection
        static int viewAccountListing()
        {
            int selectedItem = 0;
            Console.Clear();
            Console.WriteLine("Select the account or 1 to return:");
            Console.WriteLine(" 1. Assets\n 2. Liabilities\n 3. Equities\n 4. Revenue\n 5. Expenses\n 6. Gains\n 7. Losses\n");
            selectedItem = int.Parse(Console.ReadLine());
            return selectedItem;

        //NEED Method or Loop or Case to display the appropriate account ledger
        //after ledger is displayed, enter 1 to return to account listing
        }


        //Method to display the main menu items to the screen and return user's selection
        static int selectMainMenuItem ()
        {
            int selectedItem = 0;
            Console.Clear();
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine(" 1. Check Balances\n 2. View Account\n 3. Enter a Transaction\n 4. View Reports\n 0. Exit Program\n");
            selectedItem = int.Parse(Console.ReadLine());
            return selectedItem;
        }
        //Method to display accounts and balances
        //NEED to complete SQL to show the balances of each account
        static int checkBalances ()
        {
            int selectedItem = 0;
            Console.Clear();
            Console.WriteLine("Your current balances are:\n");
            Console.WriteLine(" 1. Return\n Assets (Balance)\n Liabilities (Balance)\n Equities (Balance)\n Revenue (Balance)\n Expenses (Balance)\n Gains (Balance)\n Losses (Balance)\n");
            Console.WriteLine("Enter 1 to return: ");
            selectedItem = int.Parse(Console.ReadLine());
            if (selectedItem != 1)
            {
                Console.WriteLine("Please enter 1 to return: ");
            }
            return selectedItem;
        }

        static bool actOnSelectedItem(int selectedItem)

        {
            var exitMenu = false;

            switch (selectedItem)
            {
                case 1:
                    checkBalances();
                    break;
                case 2:
                    viewAccountListing();
                    break;
                case 3:
                    enterTransaction();
                    break;
                case 4:
                    //call View Reports Method
                    break;
                case 0:
                    exitMenu = true;
                    break;
                default:
                    Console.WriteLine("Please select an item from the menu as 1 - 4");
                    break;
            }
            return exitMenu;

        }
    }
}
