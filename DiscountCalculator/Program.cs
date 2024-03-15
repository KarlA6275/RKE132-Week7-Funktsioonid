//total < 10 - 1%
//total >= 10 && total < 20 - 5%
//total >= 20 - 10%

Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculatedDiscount(userInput);

Console.WriteLine($"Your discount is: {discount} %");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your new total with discount of {discount}% is: {newTotal}€");



static double CalculatedDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - ((total * discount) / 100);
    return result;
}