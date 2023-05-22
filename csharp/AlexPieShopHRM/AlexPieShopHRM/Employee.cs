using System.Text;
using Newtonsoft.Json;

namespace AlexPieShopHRM;

public class Employee
{
    public string firstName;
    public string lastName;
    public string email;

    public int numberOfHoursWorked;
    public double wage;
    public double hourlyRate;

    public DateTime birthDay;

    public string ConvertToJson()
    {
        string json = JsonConvert.SerializeObject(this);
        return json;
    }
    public void PerformWork()
    {
        numberOfHoursWorked++;
        Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)");
        // method code goes here
    }
    public void PerformWork(int numberOfHours)
    {
        numberOfHoursWorked+= numberOfHours;
        Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)");
        // method code goes here
    }
}