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
            //Execute method for user to select choice from menu and return thier selection
            int selectedItem = selectMainMenuItem();

            //Possibly break this out as a method of it's own and test for valid input...
            //will this run back to the top from the default?  May need to convert this to a loop???
            switch (selectedItem)
            {
                case 1:
                    //need to look at break and see how to exit (do-while loop work)
                    break;
                case 2:
                    checkBalances();
                    break;
                case 3:
                    viewAccountListing();
                    break;
                case 4:
                    enterTransaction();
                    break;
                case 5:
                    //call View Reports Method
                    break;
                default:
                    Console.WriteLine("Please select an item from the menu as 1 - 4");
                    break;
            }
            //Console.WriteLine($"You chose item number: {selectedItem}");



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
            Console.WriteLine(" 1. Exit\n 2. Check Balances\n 3. View Account\n 4. Enter a Transaction\n 5. View Reports\n");
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
    }
}
