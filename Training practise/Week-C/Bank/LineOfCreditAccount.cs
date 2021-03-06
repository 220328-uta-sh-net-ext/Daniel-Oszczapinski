namespace Bank
{
    public class LineOfCreditAccount : BankAccount
    {
 public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
{
    
    if (Balance < 0)
    {
        // Negate the balance to get a positive interest charge:
        decimal interest = -Balance * 0.07m;
        MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
    }
}
    }
}