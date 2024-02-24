// See https://aka.ms/new-console-template for more information

using ClassesStructsAndRecords;

Employee employee = new Employee("Aaron", "Burk");
Employee employeeWithOptionalId = new Employee("Dylan", "Burk", new Random().Next(1, 10));
Employee employeeWhoIsManager = new Manager("Charlie", "Brown");

// won't compile because type is Employee
// employeeWhoIsManager.NumberOfDirectReports = 2;

Manager manager = new Manager("Charlie", "Brown");
manager.NumberOfDirectReports = 2;
