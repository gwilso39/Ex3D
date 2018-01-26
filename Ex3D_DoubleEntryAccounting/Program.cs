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
                    //Place int value of selected item in the parameter of what to do with it
                    //if entered 0, boolean changes to true and program exits

                    exitProgram = actOnMainMenuSelectedItem(selectMainMenuItem());
                    
                //as long as user hasn't entered 0 program remains running
                } while (!exitProgram);
            }
        }
        
        //Method to enter a transaction, PLUS a STRETCH GOAL - be able to split a transation between accounts
        static void enterTransaction()
        {
            var done = false;
            Console.Clear();

            do
            {
                Console.WriteLine("Enter your transaction details:\n");

                try
                {
                    Console.Write("Date: ");
                    string date = Console.ReadLine();

                    Console.Write("Identifier: ");
                    string identifier = Console.ReadLine();

                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    bool goodInput = true;
                    string acctCredit;
                    string acctCredit1;
                    double amount = 0;
                    double amount1 = 0;
                    string acctDebit;
                    string acctDebit1;
                    double amountDebit = 0;
                    double amountDebit1 = 0;

                    do
                    {
                        Console.Write("Does this transaction have multiple accounts to credit? (Y or N): ");
                        char answerToCredits = char.Parse(Console.ReadLine());

                        if ((answerToCredits != 'Y') && (answerToCredits != 'N'))
                        {
                            Console.Write("Please enter Y or N only: ");
                            goodInput = false;
                        }
                        else if (answerToCredits == 'Y')
                        {
                            Console.WriteLine("You can enter 2 pairs.");
                            Console.Write("Account Credited: ");
                            acctCredit = Console.ReadLine();
                            Console.Write("Amount: $");
                            amount = double.Parse(Console.ReadLine());
                            Console.Write("2nd Account Credited: ");
                            acctCredit1 = Console.ReadLine();
                            Console.Write("2nd Amount: $");
                            amount1 = double.Parse(Console.ReadLine());
                            double sum = ((amount) + (amount1));
                            Console.Write($"\nTotal Credit = {sum}\n");
                            goodInput = true;
                        }
                        else
                        {
                            Console.Write("Account Credited: ");
                            acctCredit = Console.ReadLine();
                            Console.Write("Amount: $");
                            amount = double.Parse(Console.ReadLine());
                            goodInput = true;
                        }
                    } while (goodInput == false);

                    do
                    {
                        Console.Write("Does this transaction have multiple accounts to debit? (Y or N): ");
                        char answerToDebits = char.Parse(Console.ReadLine());

                        if ((answerToDebits != 'Y') && (answerToDebits != 'N'))
                        {
                            Console.Write("Please enter Y or N only: ");
                            goodInput = false;
                        }
                        else if (answerToDebits == 'Y')
                        {
                            Console.WriteLine("You can enter 2 pairs.");
                            Console.Write("Account Debited: ");
                            acctDebit = Console.ReadLine();
                            Console.Write("Amount: $");
                            amountDebit = double.Parse(Console.ReadLine());
                            Console.Write("2nd Account Debited: ");
                            acctDebit1 = Console.ReadLine();
                            Console.Write("2nd Amount: $");
                            amountDebit1 = double.Parse(Console.ReadLine());
                            double sum = ((amountDebit) + (amountDebit1));
                            Console.Write($"\nTotal Debit = {sum}\n");
                            goodInput = true;
                        }
                        else
                        {
                            Console.Write("Account Debited: ");
                            acctDebit = Console.ReadLine();
                            Console.Write("Amount: $");
                            amountDebit = double.Parse(Console.ReadLine());
                            goodInput = true;
                        }
                    } while (goodInput == false);

                    Console.WriteLine("\nReview your details and press 1 to save 0 to go back");
                    double lhs = ((amount) + (amount1));
                    double rhs = ((amountDebit) + (amountDebit1));
                    Console.Write($"Note: Credits = ${lhs} and Debits = ${rhs}.\nEnter 1 or 0: ");

                    int decMade = int.Parse(Console.ReadLine());
                    if (decMade == 1)
                    {
                        //code here for database save
                        Console.WriteLine("Your data is saved");
                        Console.WriteLine("Hit enter to continue");
                        Console.ReadLine();
                        done = true;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            } while (!done);
        }
        
        //Method to View Account Listing for further selection
        static int viewAccountListing()
        {
            int selectedItem = 0;
            var validInput = false;
            Console.Clear();

            do
            {
                validInput = false;
                Console.WriteLine("Select the account or 0 to return:");
                Console.WriteLine(" 1. Assets\n 2. Liabilities\n 3. Equities\n 4. Revenue\n 5. Expenses\n 6. Gains\n 7. Losses\n");

                try
                {
                    selectedItem = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }
            }while ((!validInput) || ((selectedItem >= 8) || (selectedItem < 0)));

            return selectedItem;
        }
        
        //NEED a Method to display the appropriate account ledger base on the account selected

        //Method to display the main menu items to the screen and return user's selection
        static int selectMainMenuItem ()
        {
            int selectedItem = 0;
            var validInput = false;
            Console.Clear();

            do
            {
                validInput = false;
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine(" 1. Check Balances\n 2. View Account\n 3. Enter a Transaction\n 4. View Reports\n 0. Exit Program\n");
                Console.Write("Enter 1-4 or 0 to Exit: ");

                try
                {
                    selectedItem = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }
            } while ((!validInput) || ((selectedItem >= 5) || (selectedItem < 0)));

            return selectedItem;
        }
        
        //Method to display accounts and balances
        //NEED to complete SQL to show the balances of each account
        static int checkBalances ()
        {
            int selectedItem = 0;
            var validInput = false;
            do
            {
                validInput = false;
                Console.Clear();
                Console.WriteLine("Your current balances are:\n");
                Console.WriteLine(" 1. Return\n Assets (Balance)\n Liabilities (Balance)\n Equities (Balance)\n Revenue (Balance)\n Expenses (Balance)\n Gains (Balance)\n Losses (Balance)\n");
                Console.Write("Enter 1 to return: ");

                try
                {
                    selectedItem = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.Write("Invalid Input");
                }
            } while ((!validInput) || (selectedItem != 1));
            
            return selectedItem;
        }
        
        //Method to determine which method to call based on whatever item is selected from the Main Menu
        static bool actOnMainMenuSelectedItem(int selectedItem)

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
                    viewReportsMenu();
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

        //Method to view the reports listing THIS WAS also a STRETCH GOAL
        static int viewReportsMenu()
        {
            int selectedItem = 0;
            var validInput = false;
            Console.Clear();

            do
            {
                validInput = false;
                Console.WriteLine("Select a report to view or 0 to return:");
                Console.WriteLine(" 1. Income Statement\n    Revenue + Interest - Income taxes\n " +
                    "2. Total Assets\n    Assets + Revenue + Equity\n " +
                    "3. Liabilities\n    Liabilities + Expenses\n " +
                    "4. Balance Sheet\n    Assets - Liabilities\n");

                try
                {
                    selectedItem = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }
            } while ((!validInput) || ((selectedItem >= 8) || (selectedItem < 0)));

        return selectedItem;

        }

        //NEED a Method to show the report the user wants to see.
    }
}
