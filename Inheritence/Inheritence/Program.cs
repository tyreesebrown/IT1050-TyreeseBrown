using System;

public class Account
{
    decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0.0M)
            {
                balance = value;
            }
            else
            {
                balance = 0.0M;
                Console.WriteLine("Initial balance was invalid. Zero used");
            }
        }
    }

    public Account(decimal balance)
    {
        Balance = balance;
    }

    public virtual void Credit(decimal amount)
    {
        balance += amount;
    }

    public virtual bool Debit(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return true;
        }
        else
        {
            Console.WriteLine("Debit amount exceeded account balance.");
            return false;
        }
    }

}

public class SavingsAccount : Account
{
    decimal interestRate;

    public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
    {
        this.interestRate = interestRate;
    }

    public decimal CalculateInterest()
    {
        return Balance * interestRate / 100m;
    }
}

public class CheckingAccount : Account
{
    decimal fee;

    public CheckingAccount(decimal balance, decimal fee) : base(balance)
    {
        this.fee = fee;
    }

    public override void Credit(decimal amount)
    {
        base.Credit(amount);
        Balance -= fee;
    }

    public override bool Debit(decimal amount)
    {
        if (base.Debit(amount))
        {
            Balance -= fee;
            return true;
        }
        else
        {
            return false;
        }
    }

}
class Program
{
    static void Main()
    {
        Account acc1 = new Account(350);
        Console.WriteLine("Intial balance account 1 : $" + acc1.Balance);
        acc1.Credit(200);
        acc1.Debit(50);
        Console.WriteLine("Final balance of account 1 : $" + acc1.Balance);
        Console.WriteLine();

        Account acc2 = new Account(-3);
        Console.WriteLine("Intial balance of account 2 : $" +  acc2.Balance);
        acc2.Credit(30);
        acc2.Debit(400);
        Console.WriteLine("Final balance of account 2 : $" +  acc2.Balance);
        Console.WriteLine();

        SavingsAccount acc3 = new SavingsAccount(100, 5);
        Console.WriteLine("Intial balance of account 3 : $" + acc3.Balance);
        acc3.Credit(400);
        acc3.Debit(240);
        Console.WriteLine("Current balance of account 3 : $" + acc3.Balance);
        decimal interest = acc3.CalculateInterest();
        acc3.Credit(interest);
        Console.WriteLine("Final balance of account 3 : $" + acc3.Balance);
        Console.WriteLine();

        CheckingAccount acc4 = new CheckingAccount(100, 2.5M);
        Console.WriteLine("Intial balance of account 4 : $" + acc4.Balance);
        acc4.Credit(300);
        acc4.Debit(175);
        Console.WriteLine("Final balance of account 4 : $" + acc4.Balance);

        Console.ReadKey();
    }
}
