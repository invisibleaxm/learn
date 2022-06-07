// See https://aka.ms/new-console-template for more information
using AlexPieShopHRM;

int months = 12, bonus = 1000;
double ratePerHour = 12.34;
int numberOfHoursWorked = 165;
var test = "alex";
Console.WriteLine(test);

int amount = 1234;
int months = 12;

int yearlyWage = Utilities.CalculateYearlyWage(amount,months);
Console.WriteLine($"Yearly Wage: {yearlyWage}");
Utilities.UsingNamedArguments();
Console.ReadLine();
