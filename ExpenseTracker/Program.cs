// See https://aka.ms/new-console-template for more information
using ExpenseTracker;
    
class Program {
    static void Main(string[] args)
    {
        ExpenseService expense = new ExpenseService();
        
        Console.WriteLine("Enter date of expense");
        string date = Console.ReadLine();
        
        Console.WriteLine("Enter the amount of expense");
        int amount = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter description");
        string description = Console.ReadLine();
        
        
        expense.addExpense(date, amount, description);
        expense.returnExpenseLists();
        
    }}     