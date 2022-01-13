using System.Collections;
using static System.Console;

//int x = 0;

//while (x < 10)
//{
//    Console.WriteLine(x);
//    x++;
//}

//string? password;

//int attempts = 0;
//do
//{
//    Write("Enter your password: ");
//    password = ReadLine();
//    ++attempts;
//    if(attempts == 2 && password != "Pa$$w0rd")
//    {
//        WriteLine("You have reached the maximum number of attemts! Please try again later...");
//        break;
//    }
//}
//while (password != "Pa$$w0rd");
//if(password == "Pa$$w0rd")
//{
//    WriteLine("Correct! Welcome!");
//}

for(int i = 0; i <= 10; i++)
{
    WriteLine(i);
}

string[] names = { "Adam", "Barry", "Charlie" };
foreach(string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}
