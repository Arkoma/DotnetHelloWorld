// See https://aka.ms/new-console-template for more information
using EnumsAndNullables;

string input = null;
int definiteInt;
int? age = null; // question mark makes it nullable
Nullable<int> age2 = null; // alternative nullable syntax

age = 5;
age ??= 12; // if age is null make it equal to 12
//definiteInt = age; // doing this without casting it to int? results in compilation error stating 
                   //   Program.cs(11, 15): [CS0266] Cannot implicitly convert type 'int?' to 'int'.
                   //   An explicit conversion exists (are you missing a cast?)

definiteInt = age ?? 17; // if age is null make definateInt 17 otherwise asign it the value of age
// equivalent of
definiteInt = age != null ? age.Value : 17;
Console.WriteLine($"{definiteInt}");

// if (definiteInt != null) // compilation error unassigned local variable
if (age != null) // compilation error unassigned local variable
{
    Console.WriteLine($"String is: {age}");
}

if (age.HasValue)
{
    Console.WriteLine($"Age's value: {age.Value}");
}