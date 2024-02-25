// See https://aka.ms/new-console-template for more information

using ClassesStructsAndRecords;

// Employee sw = new ShiftWorker
// ShiftWorker sw = new ShiftWorker
// {
//     FirstName = "staff",
//     LastName = "one",
//     StartDate = new DateOnly(2014, 2, 17),
//     ShiftStartTime = new TimeOnly(8, 30)
// };
//
// Console.WriteLine("==========Shift Worker==========");
// bool payrollProcessed = sw.ProcessPayroll();
// sw.Terminate(DateTime.Now);
// bool active = sw.IsActive();// runs Employee version of method if 
//                             // if typed as Employee
//                             // runs ShiftWorker version
//                             // if typed as ShiftWorker
// Console.WriteLine();

// Employee mgr = new Manager
Manager mgr = new Manager
{
    FirstName = "manager",
    LastName = "one",
    NumberOfDirectReports = 7
};
Console.WriteLine("==========Manager==========");
bool mgrPayrollProcessed = mgr.ProcessPayroll();
mgr.Terminate(DateTime.Now); // overridden so calls derived
bool mgrActive = mgr.IsActive();
