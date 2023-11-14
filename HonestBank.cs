using System;
using System.Collections.Generic;

// Factory Method Pattern: Product
public interface ITransaction
{
    void Execute();
}

// Factory Method Pattern: Concrete Products
public class DepositTransaction : ITransaction
{
    public void Execute()
    {
        Console.WriteLine("Executing deposit transaction.");
    }
}

public class WithdrawTransaction : ITransaction
{
    public void Execute()
    {
        Console.WriteLine("Executing withdraw transaction.");
    }
}

// Factory Method Pattern: Creator
public interface ITransactionFactory
{
    ITransaction CreateTransaction();
}

// Factory Method Pattern: Concrete Creators
public class DepositTransactionFactory : ITransactionFactory
{
    public ITransaction CreateTransaction()
    {
        return new DepositTransaction();
    }
}

public class WithdrawTransactionFactory : ITransactionFactory
{
    public ITransaction CreateTransaction()
    {
        return new WithdrawTransaction();
    }
}

// Singleton Pattern
public class Bank
{
    private static Bank _instance;

    private Bank()
    {
        Console.WriteLine("Bank instance created");
    }

    public static Bank Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Bank();
            }
            return _instance;
        }
    }
}

// Observer Pattern: Observer Interface
public interface ITransactionObserver
{
    void Update(ITransaction transaction);
}

// Observer Pattern: Concrete Observer
public class TransactionLogger : ITransactionObserver
{
    public void Update(ITransaction transaction)
    {
        Console.WriteLine($"Transaction logged: {transaction.GetType().Name}");
    }
}

// Observer Pattern: Subject
public class TransactionProcessor
{
    private List<ITransactionObserver> _observers = new List<ITransactionObserver>();

    public void AttachObserver(ITransactionObserver observer)
    {
        _observers.Add(observer);
    }

    public void ProcessTransaction(ITransaction transaction)
    {
        Console.WriteLine("Processing transaction...");
        NotifyObservers(transaction);
        transaction.Execute();
    }

    private void NotifyObservers(ITransaction transaction)
    {
        foreach (var observer in _observers)
        {
            observer.Update(transaction);
        }
    }
}