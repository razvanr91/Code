using static System.Console;
using Packt.Shared;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

// call instance method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

// call static method
Person baby2 = Person.Procreate(harry, jill);

// call an operator
Person baby3 = harry * mary;

WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");

WriteLine($"{harry.Name}'s first child is named \"{harry.Children[0].Name}\".");

WriteLine($"5! is {Person.Factorial(5)}");

static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender == null) return;

    Person p = (Person)sender;

    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

harry.Shout += Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

// non-generic lookup collection
System.Collections.Hashtable lookupObject = new();

lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;
WriteLine($"Key {key} has value {lookupObject[key]}.");

// lookup the value that has harry as its key
WriteLine($"Key {harry} has value: {lookupObject[harry]}.");

// generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine($"Key {key} has value: {lookupIntString[key]}.");

Person[] people =
{
    new() {Name = "Simon"},
    new() {Name = "Jenny"},
    new() {Name = "Adam"},
    new() {Name = "Richard"}
};

WriteLine("Initial list of people:");
foreach(Person p in people)
{
    WriteLine($"    {p.Name}");
}

WriteLine("Use Person's ICOmparable implementation to sort:");
Array.Sort(people);
foreach(Person p in people)
{
    WriteLine($"    {p.Name}");
}

WriteLine("Use PersonComparer's IComparer implementation to sort:");
Array.Sort(people, new PersonComparer());

foreach(Person p in people)
{
    Console.WriteLine($"    {p.Name}");
}

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;

WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

Employee john = new()
{
    Name = "John Jones",
    DateOfBirth = new(year: 1990, month: 7, day: 28)
};
john.WriteToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);

WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}.");

WriteLine(john.ToString());