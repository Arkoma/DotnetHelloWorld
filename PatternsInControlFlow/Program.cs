// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using EnumsAndNullables;

string input = "hello world";

Console.WriteLine(PadAndTrim(input, 15, 'z'));
Console.WriteLine(GetShiftDays(DateTime.Now.DayOfWeek));
static ShiftDays GetShiftDays(DayOfWeek day) => day switch
{
     DayOfWeek.Monday => ShiftDays.Monday,
     DayOfWeek.Tuesday => ShiftDays.Tuesday,
     DayOfWeek.Wednesday => ShiftDays.Wednesday,
     DayOfWeek.Thursday => ShiftDays.Thursday,
     DayOfWeek.Friday => ShiftDays.Friday,
     DayOfWeek.Saturday => ShiftDays.Saturday,
     DayOfWeek.Sunday => ShiftDays.Sunday,
     _ => throw new ArgumentException("Invalid day of the week supplied")
};

static string PadAndTrim([AllowNull]string input, int length, char padChar)    
{
     if (input == null)
     {
          return String.Empty.PadLeft(length, padChar);
     }
     else if (input.Length <= length)
     {
          switch (padChar)
          {
               case (>= 'a' and <= 'z') or (>= 'A' and <= 'Z'):
                    return input.Trim().PadLeft(length, padChar);
               case >= '0' and <= '9':
                    return input.Trim().PadRight(length, padChar);
               default:
                    Console.WriteLine("No match found for pad character");
                    break;
          }
          return input.Trim().PadLeft(length, padChar);
     }
     else
     {
          throw new ArgumentException("Input is longer than requested length");
     }
}

IPerson sw = new ShiftWorker { FirstName = "Shift", LastName = "Worker", StartDate = new DateOnly(2024, 2, 14)};
IPerson mgr = new Manager { FirstName = "Manager", LastName = "Worker", NumberOfDirectReports = 1000 };
Console.WriteLine(GetPersonDetails(sw));
Console.WriteLine(GetPersonDetails(mgr));
static string GetPersonDetails(IPerson p)
{
     var result = p switch
     {
          ShiftWorker swv => $"{swv.FirstName} {swv.LastName}: {swv.StartDate} ",
          Manager mgv => $"{mgv.FirstName} {mgv.LastName}, Reports: {mgv.NumberOfDirectReports}",
          _ => string.Empty
     };
     return result;
     // ShiftWorker? swv = p as ShiftWorker;
     // if (swv is not null)
     // if(p is ShiftWorker swv) // this does the null check, type check, and var assignment all at once
     // {
          // return $"{swv.FirstName} {swv.LastName}: {swv.StartDate} ";
     // } else if (p is Manager mgv)
     // {
          // return $"{mgv.FirstName} {mgv.LastName}, Reports: {mgv.NumberOfDirectReports}";
     // }
     // return String.Empty;
}
