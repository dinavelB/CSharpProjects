namespace ExpenseTracker;
using ExpenseTracker.common;

public class ExpenseService
{

    private int listNum;
    private List<Expense> _expenses = new List<Expense>();
    
    public string addExpense (string date, int amount, string description)
    {
        try
        {
            // this is how to create an object in cSharp
            // parent => child
            Expense expenseRec = new Expense
            {
                Date = date,
                Amount = amount,
                Description = description
            };
            
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
        // foreach is the only thing csharp has
        // that matches with the for loop of TS
       foreach (Expense expenseRec in this._expenses)
       {
           this.listNum++;
           Console.WriteLine($"{listNum}. Date: {expenseRec.Date}, Amount: ${expenseRec.Amount}, Description: {expenseRec.Description}");
       }
    }
}