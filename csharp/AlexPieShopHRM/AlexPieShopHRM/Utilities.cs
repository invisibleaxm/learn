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
    
}