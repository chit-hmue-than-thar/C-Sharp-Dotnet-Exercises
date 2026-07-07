// See https://aka.ms/new-console-template for more information

using JuneIntake.SQLInjection;

Console.WriteLine("---Login---");
Console.Write("Enter Name: ");
var username = Console.ReadLine();
Console.Write("Enter Password: ");
var password = Console.ReadLine();

LoginService loginservice = new LoginService();
loginservice.Login(username, password);

