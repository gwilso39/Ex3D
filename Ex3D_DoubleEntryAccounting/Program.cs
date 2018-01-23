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
                    //call View Accounts Method
                    break;
                case 4:
                    //call Enter Transactions Method
                    break;
                case 5:
                    //call View Reports Method
                    break;
                default:
                    Console.WriteLine("Please select an item from the menu as 1 - 4");
                    break;
            }
            Console.WriteLine($"You chose item number: {selectedItem}");


            //Method to Check Balances show the following:
            //each of the 7 accounts and their current balances
            //upon completion of checking balance, enter 1 to return to main menu

            //Method to View Account Listing for further selection
            //which account would you like?  show a screen with 7 accounts with numbers to select
            //enter 1 to return to main menu

            //Method or Loop or Case to display the appropriate account ledger
            //after ledger is displayed, enter 1 to return to account listing

            //Method to enter a transaction, ask through the transation for the items:
            //ID(key performatted, Date, Description (free text), USD, Acct to Credit, Acct to Debit
            //as a stretch goal - be able to split a transation between accounts
            //after last item is entered for entry, ask to save transaction or discard
            //if saved, push transaction to database
            //ask user to "enter 1 for main menu" and "enter 2 for another transaction"

            //Method to show a menu of reports available and return which one is selected
            //continue to use item 1 as return to main menu
            //What are some standard reports needed?  
            //Balance Sheet (Assets=Liabilities + Capitol)
            //Income Statement (Revenue Expenses Gains Losses)
            //Equity Statment (Equity changes)            

            //Method to compile individual reports (each?)
        }

        //Method to display the main menu items to the screen and return user's selection
        //menu items include "Check Balances" "View Account" "Enter a Transaction" "View Reports"

        static int selectMainMenuItem ()
        {
            int selectedItem = 0;
            Console.Clear();
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine(" 1. Exit\n 2. Check Balances\n 3. View Account\n 4. Enter a Transaction\n 5. View Reports\n");
            selectedItem = int.Parse(Console.ReadLine());
            return selectedItem;
        }
        //method to display accounts and balances
        //NEED to complete SQL to show the balances of each account
        static int checkBalances ()
        {
            int selectedItem = 0;
            Console.Clear();
            Console.WriteLine("Your current balances are:\n");
            Console.WriteLine(" 1. Assets (Balance)\n 2. Liabilities (Balance)\n 3. Equities (Balance)\n 4. Revenue (Balance)\n 5. Expenses (Balance)\n 6. Gains (Balance)\n 7. Losses (Balance)\n");
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
