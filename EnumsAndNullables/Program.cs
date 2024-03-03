// See https://aka.ms/new-console-template for more information
using EnumsAndNullables;

var day = DayOfWeek.Monday;
// Console.WriteLine(day); // Monday
var shiftDay = ShiftDays.Tuesday;
// Console.WriteLine(shiftDay); // Tuesday
// Console.WriteLine((int) shiftDay); // 4

ShiftWorker d = new ShiftWorker() { FirstName = "Dynamic", LastName = "Worker" };
d.DaysAvailable = ShiftDays.Wednesday;
Console.WriteLine(d.DaysAvailable);
