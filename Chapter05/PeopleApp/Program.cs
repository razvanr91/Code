using System;
using static System.Console;
using Packt.Shared;

Person bob = new();

bob.Name = "Bob Smith";
bob.DateOfBIrth = new DateTime(1965, 12, 22);

//WriteLine($"{bob.Name} was born on {bob.DateOfBIrth:dddd, d MMMM yyyy}");

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBIrth = new(1998, 3, 7)
};

//WriteLine($"{alice.Name} was born on {alice.DateOfBIrth:dd MM yy}.");

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

WriteLine($"{bob.Name}`s favorite wonder is {bob.FavoriteAncientWonder}. Its integer is {(int)bob.FavoriteAncientWonder}.");

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine($"{bob.Name}`s bucket list is {bob.BucketList}.");

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for(int i = 0; i < bob.Children.Count; i++)
{
    WriteLine($"    {bob.Children[i].Name}");
}

foreach(Person child in bob.Children)
{
    WriteLine(child.Name);
}

BankAccount.InterestRate = 0.012M;

BankAccount jonesAccount = new();

jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest.");

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:c} interest.");

WriteLine($"{bob.Name} is a {Person.Species}.");