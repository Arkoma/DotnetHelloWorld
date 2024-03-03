// See https://aka.ms/new-console-template for more information
using EnumsAndNullables;

var day = DayOfWeek.Monday;
// Console.WriteLine(day); // Monday
var shiftDay = ShiftDays.Tuesday;
// Console.WriteLine(shiftDay); // Tuesday
// Console.WriteLine((int) shiftDay); // 4

ShiftWorker d = new ShiftWorker() { FirstName = "Dynamic", LastName = "Worker" };
d.DaysAvailable = ShiftDays.Wednesday | ShiftDays.Thursday; // 24 without Flags attribute but
                                                            // Wednesday, Thursday with it.
d.DaysAvailable = ShiftDays.Saturday | ShiftDays.Sunday; // adds the values of the enums and returns Weekend.
d.DaysAvailable = ShiftDays.Weekdays; // ShiftDays.Weekend; // Monday, Tuesday, Wednesday, Thursday, Friday, Weekend
Console.WriteLine(d.DaysAvailable);
Console.WriteLine($"Has Monday available: {d.DaysAvailable.HasFlag(ShiftDays.Monday)}");
bool availableDays = (d.DaysAvailable & ShiftDays.Saturday) == ShiftDays.Saturday;
Console.WriteLine($"Available Saturday?  {availableDays}");

Console.WriteLine(String.Join(", ", Enum.GetNames(typeof(ShiftDays))));
Console.WriteLine(String.Join(", ", (short[]) Enum.GetValues(typeof(ShiftDays))));
