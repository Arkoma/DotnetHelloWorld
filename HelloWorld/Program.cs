// See https://aka.ms/new-console-template for more information
using HelloWorld;

Person me = new Person
{
    FirstName = "Aaron",
    LastName = "Burk"
};

Console.WriteLine("Hello, from, {0} {1}, to you!", me.FirstName, me.LastName);
