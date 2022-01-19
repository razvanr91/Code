﻿namespace Packt.Shared;

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person? x, Person y)
    {
        if(x == null || y == null)
        {
            return 0;
        }

        // compare name length
        int result = x.Name.Length.CompareTo(y.Name.Length);

        if(result == 0)
        {
            // compare by names
            return x.Name.CompareTo(y.Name);
        }
        else // result will be -1 or 1
        {
            return result;
        }
    }
}