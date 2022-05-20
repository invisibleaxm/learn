// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Console.WriteLine("The meaning of life is {0}", a.ToString());
// Console.WriteLine("Press any key to continue");
// Console.ReadLine();

int months = 12, bonus = 1000;
double ratePerHour = 12.34;
int numberOfHoursWorked = 165;
var test = "alex";
Console.WriteLine(test);

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
ratePerHour += 3;
Console.WriteLine(ratePerHour);
Console.WriteLine(currentMonthWage);
if (ratePerHour > 2000)
    Console.WriteLine("Top paid employee");

int numberofEmployees = 15;

numberofEmployees--;
Console.WriteLine(numberofEmployees);

int b;

string name = string.Empty;
char a = 'a';
char.IsLower(a);

DateTime hireDate = new DateTime(2023, 03, 28);
Console.WriteLine(hireDate.ToLongDateString());

DateTime exitDate = new DateTime(2025, 12, 11);
DateTime startDate = hireDate.AddDays(15);

DateTime currentDate = DateTime.Now;

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine(startHour.ToLongDateString());
Console.WriteLine(endHour.ToShortTimeString());

Console.ReadLine();

var age = 23;
switch(age)
{
    case < 18:
        Console.WriteLine("Too young to apply");
        break;
    case > 65:
        Console.WriteLine("Too old to apply");
        break;
    case 42:
        Console.WriteLine("Wow, exactly what we are looking for");
        break;
    default:
        Console.WriteLine("Great you can continue");
        break;
}


Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());
int i = 0;
while (i < max)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("Finished Loop");

Console.WriteLine("Choose the action you want to do: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
string selectedAction = Console.ReadLine();

switch (selectedAction)
{
    case "1":
        Console.WriteLine("Adding new employee...");
        break;
    case "2":
        Console.WriteLine("Updating employee...");
        break;
    case "3":
        Console.WriteLine("Deleting employee...");
        break;
    default:
        Console.WriteLine("InvalidInput");
        break;
}
