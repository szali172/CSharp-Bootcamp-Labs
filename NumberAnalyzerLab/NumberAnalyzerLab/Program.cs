
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Great! Nice to meet you {name}");

while (true)
{
    Console.WriteLine($"\nEnter an integer between 1 and 100 (inclusive), {name}. Type \"stop\" to stop the program...");
    string userInput = Console.ReadLine();

    // Check input
    if (userInput == "stop")
    {
        break;
    }


    int userInputInt = int.Parse(userInput);

    // Specific actions based on input
    if (userInputInt < 1 || userInputInt > 100)
    {
        Console.WriteLine("The number you have entered is out of the range from 1 to 100 (inclusive). Please try again...");
    }
    else if (userInputInt % 2 != 0 && userInputInt < 60)
    {
        Console.WriteLine($"{userInputInt}: Odd and less than 60");
    }
    else if (userInputInt % 2 == 0 && 2 <= userInputInt && userInputInt <= 24)
    {
        Console.WriteLine($"{name}, the number you have entered is even and less than 25");
    }
    else if (userInputInt % 2 == 0 && 26 <= userInputInt && userInputInt <= 60)
    {
        Console.WriteLine($"{name}, the number you have entered is even and between 26 and 60 inclusive.");
    }
    else if (userInputInt % 2 == 0 && userInputInt > 60)
    {
        Console.WriteLine($"{userInputInt}: Even and greater than 60");
    }
    else if (userInputInt % 2 != 0 && userInputInt > 60)
    {
        Console.WriteLine($"{userInputInt}: Odd and greater than 60");
    }
}
Console.WriteLine($"Thanks for joining {name}!");