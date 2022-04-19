namespace Bank
{
    public class InterestEarningAccount : BankAccount
    {
public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
{
    if (Balance > 500m)
    {
        decimal interest = Balance * 0.05m;
        MakeDeposit(interest, DateTime.Now, "apply monthly interest");
    }
}
    }
}