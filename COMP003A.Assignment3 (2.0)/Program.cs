using System;

namespace COMP003A.Assignment3__2._0_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int done;
           
            //name of expenses
            string expenseName1 = Console.ReadLine();
            string expenseName2 = Console.ReadLine();
            string expenseName3 = Console.ReadLine();
            string expenseName4 = Console.ReadLine();
            string expenseName5 = Console.ReadLine();
            
            //amount of expenses
            double expenseValue1 = 0;
            double expenseValue2 = 0;
            double expenseValue3 = 0;
            double expenseValue4 = 0;
            double expenseValue5 = 0;

            //total expenses
            double budget;
            
            Console.WriteLine("Welcome to the budget Management Tool!\n");
            
            Console.Write("Enter your monthly income: ");
            budget = double.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease select from the following Menu.");
            while (true)
            {
                Console.WriteLine("1. Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit\n");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                
                if (choice == 4) break;



               
                if (choice == 1)
                {
                    Console.Write("\nAdd up to 5 expese names and amounts.\n");
                    Console.WriteLine("If no other expenses enter 'skip' with a value of zero.");
                    

                    Console.Write("Enter the expense name: ");
                    expenseName1 = Console.ReadLine();
                    Console.Write("Enter the expense amount: ");
                    expenseValue1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second expense name: ");
                    expenseName2 = Console.ReadLine();
                    Console.Write("Enter the second expense amount: ");
                    expenseValue2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the third expense name: ");
                    expenseName3 = Console.ReadLine();
                    Console.Write("Enter the third expense amount: ");
                    expenseValue3 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the fourth expense name: ");
                    expenseName4 = Console.ReadLine();
                    Console.Write("Enter the fourt expense amount: ");
                    expenseValue4 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the fifth expense name: ");
                    expenseName5 = Console.ReadLine();
                    Console.Write("Enter the fifth expense amount: ");
                    expenseValue5 = int.Parse(Console.ReadLine());

                    
                    Console.Write("\nExpenses added successfully!\n Enter '5' when done: ");
                    done = int.Parse(Console.ReadLine());
                    
                    if (choice == done) break;
                }

                
                
                
                if (choice == 2)
                {
                    Console.Write($"First expense - {expenseName1}: ${expenseValue1}\n");
                    Console.Write($"Second expense - {expenseName2}: ${expenseValue2}\n");
                    Console.Write($"Third expesnse - {expenseName3}: ${expenseValue3}\n");
                    Console.Write($"Fourth expense - {expenseName4}: ${expenseValue4}\n");
                    Console.Write($"Fifth expense - {expenseName5}: ${expenseValue5}\n");
                    Console.Write($"Total Expenses: ${budget - (expenseValue1 + expenseValue2 + expenseValue3 + expenseValue4 + expenseValue5)}\n");
                    Console.Write($"Remaining Budget: ${expenseValue1 + expenseValue2 + expenseValue3 + expenseValue4 + expenseValue5}\n");

                    Console.Write("\nEnter '5' when done: \n");
                    done = int.Parse(Console.ReadLine());

                    if (choice == done) break;
                }

                if (choice == 3)
                {   //only enter rent to successfully calculate budget
                    Console.Write("\nEnter the name of the expense to remove: ");
                    Console.ReadLine();

                    switch (expenseName1)
                    {
                    case "Rent":
                        Console.WriteLine($"Removed {expenseName1}");
                        Console.Write("Expense removed successfully!\n");
                        Console.WriteLine($"New Balance: {budget - expenseValue1}");
                            break;
                        
                        default:
                        Console.WriteLine("Press 'Enter' to return");
                            break;
                    }



                    Console.Write("\nEnter '5' when done: \n");
                    done = int.Parse(Console.ReadLine());

                    if (choice == done) break;
                }
            }
            
        }
    }
}
