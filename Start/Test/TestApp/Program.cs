// // See https://aka.ms/new-console-template for more information


// // C# code​​​​​​‌‌​​‌​‌‌​​‌​​‌‌​‌‌​​​​​​‌ below
using System;

// // Write your answer here, and then test your code.
// // Your job is to implement the findLargest() method.

// public class Answer {

//     // Change these Boolean values to control whether you see 
//     // the expected result and/or hints.
//    public  static Boolean ShowExpectedResult = true;
//    public  static Boolean ShowHints = true;

// }

// public class BankAccount {
//     string firstName;
//     string lastName;
//     public decimal balance {
//         get; set;
//     }
//     public string accountOwner{
//         get => $"{firstName} {lastName}";
//     }

//     public BankAccount(string fn, string ln){
//         this.firstName = fn;
//         this.lastName = ln;
//         this.balance = 0.0m;
//     }
//     public virtual void Deposit(decimal amount){
//         this.balance += amount;
//     }

//     public virtual void Withdrawal(decimal amount){
//         this.balance -= amount;
//     }

// }

// public class CheckingAcct : BankAccount {

//     public CheckingAcct(string fn, string ln) : base(fn, ln){}

//     public override void Withdrawal(decimal amount){
//         if(this.balance - amount < 0){
//             this.balance -= (amount+35);
//             return;
//         }
//         this.balance -= amount;
//         base.Deposit(amount);
//     }
// }

public class Dog {
    public Dog(){}
    public string name { get; set; } = "";
    public int Age { get; set; } = 0;
    public bool isTrained { get; set; } = false;
}

public abstract class Employee{

    static Employee(){
        IdStart = 1000;
    }
    public Employee(){
        Employee.count++;
        Id = IdStart + Employee.count;
    }

    public static int EmployeeCount{get => count;}
    public required string Name { get; set; }
    public required int Id { get; init; }
    public required string Department { get; set; }

    private static int count = 0;
    protected static int IdStart;

    public abstract void AdjustPay(decimal percentage);
}

public sealed class HourlyEmployee : Employee {
    public HourlyEmployee(){
    }
    public decimal HourlyRate { get; set; }

    public override void AdjustPay(decimal percentage){
        if (percentage > 0){
            HourlyRate += (HourlyRate * percentage/100);
        } 
        else{
            HourlyRate -= (HourlyRate * Math.Abs(percentage)/100);
        }
    }
}

public sealed class SalariedEmployee : Employee {
    public SalariedEmployee() {
        
    }
    public decimal AnnualSalary { get; set; }

    public override void AdjustPay(decimal percentage){
        if (percentage > 0){
            AnnualSalary += (AnnualSalary * percentage/100);
        } 
        else{
            AnnualSalary -= (AnnualSalary * Math.Abs(percentage)/100);
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Dog corgi = new Dog {name="Fluff", Age=4, isTrained=true};
        // Console.WriteLine($"{corgi.name} {corgi.Age}");
        HourlyEmployee Tom = new HourlyEmployee() {Name="Tom", Id=12345, Department="Accounting", HourlyRate=30m};
        Tom.AdjustPay(50);
        Console.WriteLine($"Tom's new hourly rate: {Tom.HourlyRate}");
        SalariedEmployee Sally = new SalariedEmployee {Name="Sally", Id=54321, Department="Executive", AnnualSalary=30000};
        Console.WriteLine($"{SalariedEmployee.EmployeeCount}");
    }
}


