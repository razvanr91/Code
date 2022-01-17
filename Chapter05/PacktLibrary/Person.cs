using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person : object
    {
        public string Name;

        public DateTime DateOfBIrth;


        public List<Person> Children = new List<Person>();

        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public WondersOfTheAncientWorld BucketList;

        public const string Species = "Homo Sapien";

        public readonly string HomePlanet = "Earth";

        public readonly DateTime Instantiated;

        public Person()
        {
            // set default values for fields including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated= DateTime.Now;
        }

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBIrth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        // deconstructors
        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBIrth;
        }

        public void Deconstruct(out string name, out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob= DateOfBIrth;
            fav = FavoriteAncientWonder;
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'.";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'.";
        }

        public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            return $"Command is {command}, number is {number}, active is {active}.";
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default and must be initialized inside the method

            z = 99;
            x++;
            y++;
            z++;
        }
    }
}
