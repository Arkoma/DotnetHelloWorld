// See https://aka.ms/new-console-template for more information

using ClassesStructsAndRecords;

Employee employee = new Employee("Aaron", "Burk");
Employee employeeWithOptionalId = new Employee("Dylan", "Burk", new Random().Next(1, 10));
Employee employeeWhoIsManager = new Manager("Charlie", "Brown");

// won't compile because type is Employee
// employeeWhoIsManager.NumberOfDirectReports = 2;

Manager manager = new Manager("Charlie", "Brown");
manager.NumberOfDirectReports = 2;

// This is called object initialization where you can set fields not in the constructor during object creation;
Manager manager2 = new Manager("Frank", "Sinatra")
{
    NumberOfDirectReports = 2,
    Age = new Age()
    {
        BirthDate = new DateTime(1972, 06, 07),
        YearsOld = 51
    }
};