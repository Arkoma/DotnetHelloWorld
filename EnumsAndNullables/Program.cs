// See https://aka.ms/new-console-template for more information
using EnumsAndNullables;

string input = null;
int definiteInt;
int? age = null; // question mark makes it nullable
Nullable<int> age2 = null; // alternative nullable syntax

age = 5;
age ??= 12; 
definiteInt = age ?? 17;
Console.WriteLine($"Age is: {definiteInt}");
Console.WriteLine(PadAndTrim(input, 15, '0'));
/**
 * Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
   at Program.<<Main>$>g__PadAndTrim|0_0(String input, Int32 length, Char padChar) in /Users/aburk/RiderProjects/DotnetLearning/EnumsAndNullables/Program.cs:line 17
   at Program.<Main>$(String[] args) in /Users/aburk/RiderProjects/DotnetLearning/EnumsAndNullables/Program.cs:line 13

 */

static string PadAndTrim(string input, int length, char padChar)    
{
    // return input.Trim().PadLeft(length, padChar); //throws exception when input is null
    return input?.Trim()?.PadLeft(length, padChar); // still returns null but no longer throws exception;
}