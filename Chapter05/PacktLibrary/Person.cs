﻿using System;
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
    }
}
