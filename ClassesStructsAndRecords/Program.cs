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

// This creates a compiler error: Init-only property 'ClassesStructsAndRecords.PremiereCustomer.CustomerLevel' can
// only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor
// This is because the field is defined like following
//     public byte CustomerLevel { get; init; }
// PremiereCustomer premiereCustomer = new PremiereCustomer();
// premiereCustomer.CustomerLevel = 2;

// If I don't want to use object initialization like the following, I of course could also define a constructor that
// takes byte for CustomerLevel
PremiereCustomer premiereCustomer = new PremiereCustomer()
{
    CustomerLevel = 2
};

// This gives the following compiler error because the setter is set to private like this
//     public int OrderId { get; private set; }
// Order order = new Order() { OrderId = 123 };
Order order = new Order();
order.SetOrderId(123);
// but obviously we can set it with the setter we defined for ourselves