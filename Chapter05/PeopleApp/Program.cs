﻿using System;
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

WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

Person blankPerson = new();

WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}.");

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

WriteLine($"{gunny.Name} of {gunny.HomePlanet} was created at {gunny.Instantiated:hh:mm:ss} on a {gunny.Instantiated:dddd}.");

bob.WriteToConsole();

WriteLine(bob.GetOrigin());

(string, int) fruit = bob.GetFruit();

WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

// Deconstructing a person
var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

WriteLine(bob.SayHello());

WriteLine(bob.SayHello("Razvan"));

WriteLine(bob.OptionalParameters());

WriteLine(bob.OptionalParameters("Jump!", 98.5));
WriteLine(bob.OptionalParameters());