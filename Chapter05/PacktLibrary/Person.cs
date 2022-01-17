using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : object
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
    }
}
