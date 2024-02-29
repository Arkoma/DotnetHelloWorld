// See https://aka.ms/new-console-template for more information


using ClassesStructsAndRecords;

var x = 10;
var y = "some string";

// x = 10.0; cannot do this because the implicit
// typing is static

var e = new
{
    FirstName = "Aaron", LastName = "Burk",
    Kids = new [] { "son1", "son2" }
};

Console.WriteLine();
Console.WriteLine(e.FirstName);
Console.WriteLine();
Console.WriteLine(e.Kids[1]);