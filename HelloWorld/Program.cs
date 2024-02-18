// See https://aka.ms/new-console-template for more information
using HelloWorld;

Person me = new Person();
me.FirstName = "Aaron";
me.LastName = "Burk";

Console.WriteLine("Hello, from, {0} {1}, to you!", me.FirstName, me.LastName);
