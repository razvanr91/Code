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

WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters("Poke!", active: false));

int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

int d = 10;
int e = 20;
WriteLine($"Before: d = {d}, e = {e}, f doesn`t exist yet!");
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");

Person sam = new()
{
    Name = "Sam",
    DateOfBIrth = new(1972, 1, 27)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

sam.FavoritePrimaryColor = "Red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

sam.Children.Add(new() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });

WriteLine($"Sam's first chils is {sam.Children[0].Name}.");
WriteLine($"Sam's second child is {sam.Children[1].Name}.");

// shorter syntax
WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");

object[] passengers =
{
    new FirstClassPassenger { AirMiles = 1_419 },
    new FirstClassPassenger { AirMiles = 16_562 },
    new BusinessClassPassenger(),
    new CoachClassPassenger { CarryOnKG = 25.7 },
    new CoachClassPassenger { CarryOnKG = 0},
};

foreach(object passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _                         => 2000M,
        BusinessClassPassenger _                      => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _                         => 650M,
        _                                             => 800M
    };

    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}