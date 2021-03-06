using static System.Console;

static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table:");
    for (int row = 1; row <= 12; row++)
    {
        Console.WriteLine($"{row} x {number} = {row * number}");
    }
    WriteLine();
}

static decimal CalculateTax(decimal amount, string twoLetterRegionalCode)
{
    decimal rate = 0.0M;

    switch (twoLetterRegionalCode)
    {
        case "CH": // Switzerland
            rate = 0.08M;
            break;
        case "DK": // Denmark
        case "NO": // Norway
            rate = 0.25M;
            break;
        case "GB": // United Kingdom
        case "FR": // France
            rate = 0.2M;
            break;
        case "HU": // Hungary
            rate = 0.27M;
            break;
        case "OR": // Oregon
        case "AK": // Alaska
        case "MT": // Montana
            rate = 0.0M;
            break;
        case "ND": // North Dakota
        case "WI": // Wisconsin
        case "ME": // Maine
        case "VA": // Virginia
            rate = 0.05M;
            break;
        case "CA":
            rate = 0.0825M;
            break;
        default: // most US states
            rate = 0.06M;
            break;
    }

    return amount * rate;
}


/// <summary>
/// Pass a 32-bit integer and it will be converted into its ortinal equivalent.
/// </summary>
/// <param name="number">
/// Number is a cardinal value e.g. 1,2,3 and so on.
/// </param>
/// <return>
/// Number as an orinal value e.g. 1st, 2nd, 3rd, 4th and so on.
/// </return>
static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11: // special cases
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}

static void RunCardinalToOrdinal()
{
    for (int i = 1; i <= 40; i++)
    {
        Write($"{CardinalToOrdinal(i)} ");
    }
    WriteLine();
}

static int Factorial(int number)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
            return number * Factorial(number - 1);
        }
    }
}

static void RunFactorial()
{
    for (int i = 1; i < 15; i++)
    {
        try
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch (System.OverflowException)
        {
            WriteLine($"{i}! is too big for a 32-bit integer.");
        }

    }
}

static int FibImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if(term == 2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}

//static void RunFibImperative()
//{
//    for(int i = 1; i <= 30; i++)
//    {
//        WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibImperative(term: i):N0}");
//    }
//}

static int FibFunctional(int term) =>
    term switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional(term -1) + FibFunctional(term - 2)
    };

static void RunFibFunctional()
{
    for(int i = 1; i <= 30; i++)
    {
        WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibFunctional(term: i):N0}.");
    }
}

//TimesTable(6);

//decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionalCode: "GB");
//WriteLine($"You must pay {taxToPay:C} in tax.");

//RunCardinalToOrdinal();

//RunFactorial();

//RunFibImperative();

RunFibFunctional();