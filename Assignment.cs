// See https://aka.ms/new-console-template for more information


//Grade Calculater

Console.WriteLine("Grade Calculater \n");

Console.WriteLine("Enter marks for Mathematics: ");
int Maths = Convert.ToInt32(Console.ReadLine());
if (Maths < 0 || Maths > 100)
{
    Console.WriteLine("Invalid input. Please enter valid marks (0-100): ");
    return;
}

Console.WriteLine("Enter marks for English: ");
int English = Convert.ToInt32(Console.ReadLine());

if (English < 0 || English > 100)
{
    Console.WriteLine("Invalid input. Please enter valid marks (0-100): ");
    return;
}

Console.WriteLine("Enter marks for Science: ");
int Science = Convert.ToInt32(Console.ReadLine());

if (Science < 0 || Science > 100)
{
    Console.WriteLine("Invalid input. Please enter valid marks (0-100): ");
    return;
}

int AverageMarks = (Maths + English + Science);
Console.WriteLine("\n AverageMarks:" + AverageMarks + "/300");

int TotalPercentage = (Maths + English + Science) / 3;
Console.WriteLine("\n Percentage:" + TotalPercentage + "% \n");

switch (TotalPercentage / 10)
{
    case 10:
    case 9:
        Console.WriteLine(" Final Grade A");
        break;
    case 8:
        Console.WriteLine(" Final Grade B");
        break;
    case 7:
        Console.WriteLine(" Final Grade C");
        break;
    case 6:
        Console.WriteLine(" Final Grade D");
        break;
    default:
        Console.WriteLine(" Final Grade F");
        break;
}

//Temperature converter:

Console.WriteLine("Choose the temperature scale to convert from:");
Console.WriteLine("1. Celsius");
Console.WriteLine("2. Fahrenheit");
Console.Write("Enter your choice: ");
int One = Convert.ToInt32(Console.ReadLine());

if (One == 1)
{
    Console.Write("\nEnter the temperature in Celsius: ");
    int Celsius = Convert.ToInt32(Console.ReadLine());
    var F = (Celsius * 9 / 5) + 32;
    Console.WriteLine("\n" + Celsius + " °C." + " is equal to " + F + " °F.");
    Console.WriteLine("\n Thank you for using the temperature converter!");
}
else if (One == 2)
{
    Console.Write("\nEnter the temperature in Fahrenheit: ");
    int Fahrenheit = Convert.ToInt32(Console.ReadLine());
    var C = (Fahrenheit - 32) * 5 / 9;
    Console.WriteLine("\n" + Fahrenheit + " °F." + " is equal to " + C + " °C.");
    Console.WriteLine("\nThank you for using the temperature converter!");
}
else
{
    Console.WriteLine("\nSorry! You Have Only 2 Choice,Please Select 1 and 2 Only Thank You");
}
