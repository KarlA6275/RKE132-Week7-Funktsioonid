
Console.WriteLine("Are you coming or leaving? (in/out):");
String userChoice = Console.ReadLine();

if (userChoice == "in")
{
    printhello();
}
else
{
    PrintGoodBye();
}



static void printhello()   //function / method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}

