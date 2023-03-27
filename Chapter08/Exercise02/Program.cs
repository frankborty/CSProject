using System.Text.RegularExpressions;

using static System.Console;

WriteLine("The default regular expression checks for at least one digit.");


while (true)
{
    WriteLine("Enter a regular expression (or press ENTER to use the default): ^[a-z]+$");
    string? inputRegex = ReadLine();
    if (string.IsNullOrWhiteSpace(inputRegex))
    {
        inputRegex = @"^\d+$";
    }

    WriteLine("Enter some input:");
    string? inputString = ReadLine();

    Regex r = new(inputRegex);

    WriteLine($"{inputString} matches ${inputRegex} : {r.IsMatch(inputString)}");

    WriteLine("Press ESC to end or any key to try again.");
    if (ReadKey().Key == ConsoleKey.Escape)
    {
        return;
    }
}