using System;

namespace COMP003A.Assignment3__2._0_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the budget Management Tool!\n");
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
            double totalExpenses = expenseValue1 + expenseValue2 
                + expenseValue3 + expenseValue4 + expenseValue5;
            
            
            Console.Write("Enter your monthly income: ");
            budget = double.Parse(Console.ReadLine());
            Console.WriteLine("Please select from the following Menu.");
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

                    
                    Console.Write("Expenses added successfully!\nEnter done enter '5': \n");
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
                    Console.Write($"Total Expenses: ${budget - totalExpenses}\n");
                    Console.Write($"Remaining Budget: ${totalExpenses}\n");

                    Console.Write("Enter done enter '5': \n");
                    done = int.Parse(Console.ReadLine());

                    if (choice == done) break;
                }

                if (choice == 3)
                {
                    Console.Write("Enter the name of the expense to remove: ");
                }
            }
            
        }
    }
}
