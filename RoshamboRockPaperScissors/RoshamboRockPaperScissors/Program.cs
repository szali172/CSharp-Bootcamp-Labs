while(true)
{
    Console.Write("Please enter your name: ");
    try
    {
        string name = Console.ReadLine();
        break;
    }
    catch
    {
        Console.WriteLine("Please type a valid name");
    }
}

while(true)
{
    Console.WriteLine("Please select an opponent:");
    Console.WriteLine("1) Rock Player");
    Console.WriteLine("2) Random Player");
    try
    {
        string input = Console.ReadLine();
        
    }
    catch
    {
        Console.WriteLine("Please enter 1 or 2, or the name of the player");
    }
}



