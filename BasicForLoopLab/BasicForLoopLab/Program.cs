
using System.Diagnostics.CodeAnalysis;


bool playAgain = false;

do
{
    int sum = 0;
    int i = 0;
    Console.Write("Enter a number: ");
    int userNumber = int.Parse(Console.ReadLine());
    for (i = 0; i <= userNumber; i++)
    {
        sum += i;
    }
    Console.WriteLine(sum);
    Console.WriteLine("Would you like to continue? (y/n?)");
    string userAnswer = Console.ReadLine().ToLower().Trim();
    if (userAnswer == "y")
        playAgain = true;
    else playAgain = false;

} while (playAgain == true);
Console.WriteLine("Goodbye!");

