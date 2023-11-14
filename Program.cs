// Singleton Pattern
public class Bank
{

private static Bank? _instance; //Deklarering

static Bank GetInstance()
{
    if (_instance == null)
    {
        _instance = new Bank();
        //Om ingen fanns, finns den nu. 
    }
    return _instance;
}

}
//Singleton checker
Bank s1 = Bank.GetInstance();
Bank s2 = Bank.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}


// Factory Method Pattern
ITransactionFactory depositFactory = new DepositTransactionFactory();
ITransactionFactory withdrawFactory = new WithdrawTransactionFactory();

ITransaction depositTransaction = depositFactory.CreateTransaction();
ITransaction withdrawTransaction = withdrawFactory.CreateTransaction();

// Observer Pattern
TransactionProcessor transactionProcessor = new TransactionProcessor();
TransactionLogger logger = new TransactionLogger();
transactionProcessor.AttachObserver(logger);

// Execute transactions
transactionProcessor.ProcessTransaction(depositTransaction);
transactionProcessor.ProcessTransaction(withdrawTransaction);
