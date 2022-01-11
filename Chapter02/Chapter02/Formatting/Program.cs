using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);
string formatted = string.Format(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);

Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
WriteLine($"{"Name",-10} {"Count",6:N0}");
WriteLine($"{applesText, -10} {applesCount, 6:N0}");
WriteLine($"{bananasText, -10} {bananasCount, 6:N0}");

WriteLine("Type your first name and press ENTER: ");
string? firstName = ReadLine();
WriteLine("Type your age and press ENTER: ");
string? age = ReadLine();
WriteLine($"Hello {firstName}, you loook good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");