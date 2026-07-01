using Classes;
using JuneIntake.ConsoleApp;

var account = new BankAccount("than thar", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

var account2 = new BankAccount("han thar", 1000);
Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} balance.");

account.MakeWithdrawal(200, DateTime.Now, "Rent Payment");
Console.WriteLine($"Current Balance in Accound no. {account.Number} is {account.Balance}");

account.MakeDeposit(400, DateTime.Now, "Job Savings");
Console.WriteLine($"Current Balance in Accound no. {account.Number} is {account.Balance}");

Console.WriteLine(account.GetAccountHistory());

// testing that initial balances must be positive
try
{
    var invalidAccount = new BankAccount("test account", -5000);
}
catch (Exception ex)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("====================================================");
try
{
    account.MakeWithdrawal(4000, DateTime.Now, "OverDraw from Than Thar Account");
}
catch(Exception ex)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}