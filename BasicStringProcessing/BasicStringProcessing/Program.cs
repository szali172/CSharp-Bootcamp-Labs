
while (true)
{

    Console.Write("Enter a sentence: << ");
    string sentence = Console.ReadLine();


    foreach (string word in sentence.Split(' '))
    {
        Console.WriteLine(word);
    }

    Console.WriteLine("Would you like to continue? (y/n)");
    string yesOrNo = Console.ReadLine();

    if (yesOrNo == "n")
    {
        break;
    }
}