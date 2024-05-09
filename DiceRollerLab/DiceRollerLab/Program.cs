
/* Given the total sides of the dice, generate a single random number from 1 to n */
static int GenerateRandomNumber(int sidesOfDice)
{
    Random rand = new Random();
    return rand.Next(1, sidesOfDice);
}



/* For two 6-sided dies, check if their values match an existing combination */
static string MatchCombination(int diceOne, int diceTwo)
{
    if (diceOne == 1 && diceTwo == 1)
    {
    return "Snake Eyes";
    }
    else if (diceOne == 1 && diceTwo == 2)
    {
    return "Ace Duece";
    }
    else if (diceOne == 6 && diceTwo == 6)
    {
    return "Box Cars";
    }
    else
    {
    return "";
    }
}



/* For two 6-sided dies, check if their totals match an existing combination */
static string MatchTotals(int diceOne, int diceTwo)
{
    int total = diceOne + diceTwo;

    if (total == 7 || total == 11)
    {
        return "Win";
    }
    else if (total == 2 || total == 3 || total == 12)
    {
        return "Craps";
    }
    else
    {
        return "";
    }
}




// Ask the user to enter the number of sides for the dice
int sidesToDice;
while (true)
{
    Console.WriteLine("Enter the number of sides for a pair of dice");
    string sidesToDiceStr = Console.ReadLine();

    try
    {
        sidesToDice = int.Parse(sidesToDiceStr);
        break;
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Please enter an integer...\n");
    }
}


// Ask the user to roll the dice and respond accordingly
while (true)
{
    Console.WriteLine("Press ENTER to roll the dice...");
    Console.ReadLine();

    // Generate two random numbers for dice
    int diceOne = GenerateRandomNumber(sidesToDice);
    int diceTwo = GenerateRandomNumber(sidesToDice);

    // For a standard set of die, check combinations and totals
    if (sidesToDice == 6)
    {
        string combo = MatchCombination(diceOne, diceTwo);
        string total = MatchTotals(diceOne, diceTwo);

        if (combo != "")
        {
            Console.WriteLine(combo);
        } else if (total != "")
        {
            Console.WriteLine(total);
        } else
        {
            Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}, this leaves you with a total of {diceOne + diceTwo}");
        }
    }
    else
    {
        Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}, this leaves you with a total of {diceOne + diceTwo}");
    }
    Console.WriteLine("Would you like to reroll? (y/n)");
    string reroll = Console.ReadLine();
    if (reroll == "n")
    {
        break;
    }
}

Console.WriteLine("Goodbye!");
