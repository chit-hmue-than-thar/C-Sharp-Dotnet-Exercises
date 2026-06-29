// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//string message_key = Console.ReadKey().KeyChar.ToString();
//Console.WriteLine("hello " + message_key);

int num;
decimal dec_num;
string str;
DateTime dt;


string message = Console.ReadLine();
Console.WriteLine("You entered: " + message);

Console.WriteLine("Enter your number: ");
string input = Console.ReadLine();
int result = Convert.ToInt32(input);
Console.WriteLine("Converted Int Type" + result);


Console.WriteLine("Using writeline, Enter age: ");
Console.ReadLine();
Console.Write("Using write, Enter age: ");
Console.ReadLine();

