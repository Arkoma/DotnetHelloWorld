// See https://aka.ms/new-console-template for more information


using ClassesStructsAndRecords;

var x = 10;
var y = "some string";

// x = 10.0; cannot do this because the implicit
// typing is static

Employee e = new ShiftWorker();
e.FirstName = "Hello";
// this has the error 'Cannot resolve symbol 'ShiftStartTime''
// e.ShiftStartTime = new TimeOnly(8, 30);
// but if I cast it as a ShiftWorker then the compiler is happy
((ShiftWorker)e).ShiftStartTime = new TimeOnly(8, 30);

Console.WriteLine(e.FirstName);
