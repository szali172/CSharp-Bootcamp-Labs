// Use a do while loop to output "Hello, World!"
string input = "y";
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    input = Console.ReadLine();

} while (input != "n");
Console.WriteLine("Goodbye!");


// Prompt the user for a number, create two loops that descend/ascend to that number to/from 0
while (true)
{
    Console.WriteLine("Enter a number");
    int number = int.Parse(Console.ReadLine());

    for (int i = number; i >= 0; i--)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    for (int i = 0; i <= number; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue (y/n)?");
    string yesOrNo = Console.ReadLine();
    if (yesOrNo == "n")
    {
        break;
    }
}


// Door keypad entry
bool doorIsLocked = true;
int numberOfTries = 5;

while (doorIsLocked)
{
    if (numberOfTries == 0)
    {
        Console.WriteLine("You are locked out :(");
        break;
    }
    Console.WriteLine("Enter the key code for the door..");
    int keyCode = int.Parse(Console.ReadLine());
    if (keyCode == 13579) {
        Console.WriteLine("Welcome");
        break;
    }
    else
    {
        numberOfTries--;
        Console.WriteLine($"The keyCode you have entered is not correct. You have {numberOfTries} more attempts remaining...");
    }
}



// Door keypad entry (do while loop)
int attempts = 5;
do
{
    Console.WriteLine("Enter the key code for the door...");
    int keyPass = int.Parse(Console.ReadLine());
    if (keyPass == 13579) {
        Console.WriteLine("Welcome");
        break;
    } else
    {
        attempts--;
        Console.WriteLine($"The keyCode you have entered is not correct. You have {attempts} more attempts remaining...");
    }
} while (attempts > 0);



bool unlockDoor()
{
    int attempts = 5;
    while (attempts > 0)
    {
        Console.WriteLine("Enter the key code for the door...");
        int keyPass = int.Parse(Console.ReadLine());
        if (keyPass == 13579)
        {
            Console.WriteLine("Welcome");
            return true;
        }
        else
        {
            attempts--;
            Console.WriteLine($"The keyCode you have entered is not correct. You have {attempts} more attempts remaining...");
        }
    }
    Console.WriteLine("You have been locked out :(");
    return false;
}


// Call function
Console.WriteLine("Calling unlockDoor()");
bool unlocked = unlockDoor();
Console.WriteLine("Output from function: " + unlocked);