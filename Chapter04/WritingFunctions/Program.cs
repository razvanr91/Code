using static System.Console;

static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table:");
    for(int row = 1; row <= 12; row++)
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

static string CardinalToOrdinal(int number)
{
    switch(number)
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
    for(int i = 1; i <= 40; i++)
    {
        Write($"{CardinalToOrdinal(i)} ");
    }
    WriteLine();
}

//TimesTable(6);

//decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionalCode: "GB");
//WriteLine($"You must pay {taxToPay:C} in tax.");

RunCardinalToOrdinal();