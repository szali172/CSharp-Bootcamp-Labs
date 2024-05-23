
while (true)
{
    Console.Write("Enter a sentence: << ");
    string sentence = Console.ReadLine();
    Console.WriteLine(string.Join("\n", sentence.Split(" ")));

    Console.WriteLine("Would you like to continue? (y/n)");
    string yesOrNo = Console.ReadLine();

    if (yesOrNo == "n")
    {
        break;
    }
}