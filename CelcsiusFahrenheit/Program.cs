
Console.WriteLine("Is the data in farhenheit or celsius? (F/C)");
string data = Console.ReadLine().Trim().ToLower();
Console.WriteLine("Enter the degrees");
int degrees = Int32.Parse(Console.ReadLine().Trim());

if (data == "f")
{
    ConvertToCelsius(degrees);
}
else if (data == "c")
{
    ConvertToFahrenheit(degrees);
}
else
{
    Console.WriteLine("error");
}

static void ConvertToCelsius(int degrees)
{
    Console.WriteLine("Your answer equals " + ((degrees - 32) * 5 / 9) + " celsius.");
}
static void ConvertToFahrenheit(int degrees)
{
    Console.WriteLine("Your answer equals " + ((degrees * 9) / 5 + 32) + " fahrenheit.");
}


// fahrenheit = (celsius * 9) / 5 + 32;
// celsius = (fahrenheit - 32) * 5 / 9;