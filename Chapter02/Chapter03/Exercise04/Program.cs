using static System.Console;

Write("Enter a number between 0 and 255: ");
string inputOne = ReadLine();
WriteLine();

Write("Enter another number between 0 and 255: ");
string inputTwo = ReadLine();
WriteLine();

try
{
    int result = Convert.ToInt32(inputOne) / Convert.ToInt32(inputTwo);
    WriteLine($"{inputOne} divided by {inputTwo} is {result}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()}: {ex.Message}");
}