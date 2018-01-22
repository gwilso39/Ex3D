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
            //Execute method asking user with a menu "where would you like to go?"
            int selectedItem = selectMainMenuItem();

            //Possibly break this out as a method of it's own and test for valid input...
            /*if ((selectedItem <= 0) || (selectedItem >=5))
            {
                Console.WriteLine("Please select an item from the menu as 1 - 4"); 
            }*/
            Console.WriteLine($"You chose item number: {selectedItem}");
            

            //menu items include "Check Balances" "View Account" "Enter a Transaction" "View Reports"

            //Under Check Balances show the following:
            //each of the 7 accounts and their current balances
            //upon completion of checking balance, enter 1 to return to main menu

            //under View Account show the following:
            //which account would you like?  show a screen with 7 accounts with numbers to select
            //enter 1 to return to main menu
            //once an account is selected, display that account ledger
            //after ledger is displayed, enter 1 to return to account listing

            //if enter a transaction is selected, ask through the transation for the items:
            //ID(key performatted, Date, Description (free text), USD, Acct to Credit, Acct to Debit
            //as a stretch goal - be able to split a transation between accounts
            //after last item is entered for entry, ask to save transaction or discard
            //if saved, push transaction to database
            //ask user to "enter 1 for main menu" and "enter 2 for another transaction"

            //if View reports is selected, show a menu of available reports
            //continue to use item 1 as return to main menu
            //What are some standard reports needed?  
            //Balance Sheet (Assets=Liabilities + Capitol)
            //Income Statement (Revenue Expenses Gains Losses)
            //Equity Statment (Equity changes)            
        }

        //this will be a method to call the main menu item to the screen

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
