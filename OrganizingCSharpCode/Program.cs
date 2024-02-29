// See https://aka.ms/new-console-template for more information


using ClassesStructsAndRecords;

var x = 10;
var y = "some string";

dynamic d = new ShiftWorker() {FirstName = "Dynamic", LastName = "Worker"};

string kid1 = d.Kids[1];
// this compiles

// but it throws an exception 
/*
   Unhandled exception. Microsoft.CSharp.RuntimeBinder.RuntimeBinderException: 'ClassesStructsAndRecords.ShiftWorker' 
   does not contain a definition for 'Kids'
   at CallSite.Target(Closure, CallSite, Object)
   at System.Dynamic.UpdateDelegates.UpdateAndExecute1[T0,TRet](CallSite site, T0 arg0)
   at Program.<Main>$(String[] args) in /Users/aburk/RiderProjects/DotnetLearning/OrganizingCSharpCode/
   Program.cs:line 11
 */