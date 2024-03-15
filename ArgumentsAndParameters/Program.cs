
//Console.WriteLine("Enter a word");
//string userInput = Console.ReadLine();

//printAnyWord(userInput);


//static void printAnyWord(string anyString)  //anyString - parameter
//{
//    anyString = anyString.ToUpper();   
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine(anyString);
//    }
//}

Console.WriteLine("Enter your comment:");
string userInput = Console.ReadLine();

CountSpaces(userInput);

static void CountSpaces(string someString)
{
    someString = someString.Trim();
    int wordCounter = 1;

    foreach (char symbol in someString)
    {
        if (char.IsWhiteSpace(symbol))
        {
            wordCounter++;
        }
    }

    string word = "word";
    if (wordCounter > 1)
    {
        word = "words";
    }

    Console.WriteLine($"Your comment contains {wordCounter} {word}.");
}
