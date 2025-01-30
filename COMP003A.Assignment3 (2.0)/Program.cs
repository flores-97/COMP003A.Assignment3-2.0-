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
            double budget;
            string expenseName1;
            double expenseValue1;
            string expenseName2;
            double expenseValue2;
            string expenseName3;
            double expenseValue3;
            string expenseName4;
            double expenseValue4;
            string expenseName5;
            double expenseValue5;

            Console.Write("Enter your monthly income: ");
            budget = double.Parse(Console.ReadLine());
            Console.WriteLine("Please select from the following Menu.");
            while (true)
            {
                Console.WriteLine("1. Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit\n");
                choice = int.Parse(Console.ReadLine());
                
                if (choice == 4) break;

                if (choice == 1)
                {
                    Console.Write("\nAdd up to 5 expese names and amounts.\n");
                    

                    Console.Write("Enter the expense name: ");
                    expenseName1 = Console.ReadLine();
                    Console.Write("Enter the expense amount: ");
                    expenseValue1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second expense name: ");
                    expenseName2 = Console.ReadLine();
                    Console.Write("Enter the second expense amount: ");
                    expenseValue2 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the third expense name: ");
                    expenseName3 = Console.ReadLine();
                    Console.Write("Enter the third expense amount: ");
                    expenseValue3 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the fourth expense name: ");
                    expenseName4 = Console.ReadLine();
                    Console.Write("Enter the fourt expense amount: ");
                    expenseValue4 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the fifth expense name: ");
                    expenseName5 = Console.ReadLine();
                    Console.Write("Enter the fifth expense amount: ");
                    expenseValue5 = double.Parse(Console.ReadLine());
                    Console.Write("Expenses added successfully!\nEnter done enter '5': \n");
                    done = int.Parse(Console.ReadLine());
                    
                    if (choice == done) break;
                }

            }
            
        }
    }
}
