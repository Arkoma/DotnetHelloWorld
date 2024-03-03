// See https://aka.ms/new-console-template for more information
using EnumsAndNullables;

string input = null;
int definiteInt;
int? age = null; // question mark makes it nullable
Nullable<int> age2 = null; // alternative nullable syntax

if (input != null)
{
    Console.WriteLine("String is: {input}");
}

// if (definiteInt != null) // compilation error unassigned local variable
if (age != null) // compilation error unassigned local variable
{
    Console.WriteLine($"String is: {age}");
}
