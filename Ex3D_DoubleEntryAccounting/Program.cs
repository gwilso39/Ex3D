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
            //Execute method asking user with a menu "where would you like to go?" and return thier selection
            int selectedItem = selectMainMenuItem();

            //Possibly break this out as a method of it's own and test for valid input...
            //will this run back to the top from the default?  May need to convert this to a loop???
            switch (selectedItem)
            {
                case 1:
                    //call Check Balances Method//write today
                    break;
                case 2:
                    //call View Accounts Method
                    break;
                case 3:
                    //call Enter Transactions Method
                    break;
                case 4:
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
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine(" 1. Check Balances\n 2. View Account\n 3. Enter a Transaction\n 4. View Reports\n");
            selectedItem = int.Parse(Console.ReadLine());
            return selectedItem;
        }   
    }
}
