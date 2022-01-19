﻿using static System.Console;

int thisCannotBeNull = 4;
//thisCannotBeNull = null;

int? thisCouldBeNull = null;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

Address address = new();

address.Building = null;
address.City = "London";
address.Street = null;
address.Region = null;

class Address
{
    public string? Building;

    public string Street = string.Empty;

    public string City = string.Empty;

    public string Region = string.Empty;
}

