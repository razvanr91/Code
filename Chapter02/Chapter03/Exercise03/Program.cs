using static System.Console;

for(int i = 1; i <= 100; i++)
{
    string result = i.ToString();

    if(i % 3 == 0 && i % 5 == 0)
    {
        result = "FizzBuzz";
    }
    else if(i % 3 == 0)
    {
        result = "Fizz";
    }
    else if(i % 5 == 0)
    {
        result = "Buzz";
    }

    Console.Write($"{result} ");
}