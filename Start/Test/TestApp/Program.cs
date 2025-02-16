// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello");

// C# code​​​​​​‌‌​​‌​‌‌​​‌​​‌‌​‌‌​​​​​​‌ below
using System;

// Write your answer here, and then test your code.
// Your job is to implement the findLargest() method.

public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public  static Boolean ShowExpectedResult = true;
   public  static Boolean ShowHints = true;

}

public class BankAccount {
    string firstName;
    string lastName;
    public decimal balance {
        get; set;
    }
    public string accountOwner{
        get => $"{firstName} {lastName}";
    }

    public BankAccount(string fn, string ln){
        this.firstName = fn;
        this.lastName = ln;
        this.balance = 0.0m;
    }
    public virtual void Deposit(decimal amount){
        this.balance += amount;
    }

    public virtual void Withdrawal(decimal amount){
        this.balance -= amount;
    }

}

public class CheckingAcct : BankAccount {

    public CheckingAcct(string fn, string ln) : base(fn, ln){}

    public override void Withdrawal(decimal amount){
        if(this.balance - amount < 0){
            this.balance -= (amount+35);
            return;
        }
        this.balance -= amount;
    }
}

public class SavingsAcct : BankAccount {
    
}
