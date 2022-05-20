namespace AlexPieShopHRM;

internal class Utilities
{
   public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
   {
      if (numberOfMonthsWorked == 12) // let's add a bonus month
      {
         return monthlyWage * (numberOfMonthsWorked + 1);
      }
      return monthlyWage * numberOfMonthsWorked;
   }

   public static void UsingNamedArguments()
   {
      int amounts = 1234;
      int months = 12;
      int bonus = 500;

      int r = WageWithOptionalBonus(amounts, months, bonus);
      Console.WriteLine($"Yearly wage for employee {r}");

   }

   public static int WageWithOptionalBonus(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
   {
      return monthlyWage * (numberOfMonthsWorked + bonus);
   }
}