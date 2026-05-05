namespace ExpenseTracker;
using ExpenseTracker.common;

public class ExpenseService
{
    // T is just a param when it comes to generics
    // anything can be a generic
    
    private List<Expense> _expenses = new List<Expense>();
    
    public string addExpense (string date, int amount, string description)
    {
        try
        {
            // this is how to create an object in cSharp
            // parent => child
            Expense expenseRec = new Expense
            {
                // Date = "test" can set and call since get and set
                Date = date,
                Amount = amount,
                Description = description
            };

            // expenseRec.Date = "test";
            this._expenses.Add(expenseRec);
            
        }
        catch (ArgumentException error)
        {
            Console.WriteLine(error.Message);
        }

        return "expense added successfully";
    }

    public void returnExpenseLists()
    {
    int listNum = 1;
        // foreach is the only thing csharp has
        // that matches with the for loop of TS
       foreach (Expense expenseRec in this._expenses)
       {
           Console.WriteLine($"{listNum}. Date: {expenseRec.Date}, Amount: ${expenseRec.Amount}, Description: {expenseRec.Description}");
           listNum++;
       }
    }
}