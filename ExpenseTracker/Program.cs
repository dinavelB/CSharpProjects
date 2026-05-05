// See https://aka.ms/new-console-template for more information
using ExpenseTracker;
    
class Program {
    static ExpenseService expense = new ExpenseService();
    static void Main(string[] args)
    {
        Program.RunCommand();
    }

    static void IsTryAgain(string decision)
    {   
        
        if (decision.ToLower() == "yes" )
        {
            Program.RunCommand();
        }
        else
        {
            Console.WriteLine( "exiting program...");
            return;
        }
    }

    static void RunCommand()
    {
        Console.WriteLine("Enter date of expense format (yyyy-mm-dd)");
        string date = Console.ReadLine();
        DateTime dDate = DateTime.ParseExact(date, "yyyy-MM-dd",null);
        
        Console.WriteLine("Enter the amount of expense");
        int amount = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter description");
        string description = Console.ReadLine();
        
        
        Program.expense.addExpense(dDate, amount, description);
        Program.expense.returnExpenseLists();
        
        Console.WriteLine("do you want to add more list?");
        string decision = Console.ReadLine();

        Program.IsTryAgain(decision);
    }
}     