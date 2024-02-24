// See https://aka.ms/new-console-template for more information

using ClassesStructsAndRecords;

// Classes();
// Structs();
Records();

static void Classes()
{
    Console.WriteLine("========= Classes = reference types ==========");
    
    // Create an employee
    Employee me = new Employee
    {
        FirstName = "Aaron",
        LastName = "Burk",
        Age = new Age { BirthDate = new DateTime(1972, 6, 7), YearsOld = 51 },
        Id = 1
    };

    // Create a reference to the Employee
    IPerson other = me;
    other.FirstName = "Bizarro Aaron";
    other.Age = new Age { BirthDate = new DateTime(1980, 9, 1), YearsOld = 43 };

    // examine the results of teh original object
    Console.WriteLine($"{me.FirstName} is {me.Age.YearsOld} but {other.FirstName} is {other.Age.YearsOld}");
    Console.WriteLine();
    // Because it's a reference type the result reads
    // ========= Classes = reference types ==========
    // Bizarro Aaron is 43 but Bizarro Aaron is 43
    // with a reference type when you change the copy you 
    // change the original instance that it refers to
    
    

    ChangeName(other);
    // now the passed in param is pointing to a new object
    // and the passed in class instance is still pointing
    // to the original class instance it was pointing to
    // before the new class instance Manager Burk was created
    // ChangeName(ref other);
    // with the ref keyword changes to the reference which
    // are usually only local to the method persist after
    // the method is run
    Console.WriteLine($"{other.FirstName} {other.LastName} is still {other.Age.YearsOld}.");
    Console.WriteLine();


}

// static void ChangeName(ref IPerson person)
static void ChangeName(IPerson person)
{
    person.LastName = "Unknown";
    Console.WriteLine($"Person in method is {person.FirstName} {person.LastName}");
    
    person = new Manager("Manager", "Burk")
    {
        Id = 2,
        Age = new Age { BirthDate = new DateTime(1990, 1, 1), YearsOld = 34 }
    };

    Console.WriteLine($"Person after reference change in method is {person.FirstName} {person.LastName}");
}

static void Structs()
{
    Console.WriteLine("========== Structs = value types ==========");

    Age myAge = new Age { BirthDate = new DateTime(1971, 9, 1), YearsOld = 53 };
    // because it is a struct it no longer refers to the 
    // original age instance but creates a new copy 
    // that is its own instance
    Age anotherAge = myAge;

    anotherAge.YearsOld = 42;
    Console.WriteLine($"My age is {myAge.YearsOld}, but I changed it to {anotherAge.YearsOld}.");
    
    // AgeBackwords(anotherAge, 5);
    // without ref keyword anotherAge changes local to the
    // method do not persist outside the method
    AgeBackwords(ref anotherAge, 5);
    // but with ref keyword changes persist even after
    // the method call
    Console.WriteLine($"Now I am {anotherAge.YearsOld}");
    Console.WriteLine();
}

static void AgeBackwords(ref Age startingAge, int numberOfYearsToAge)
{
    startingAge.YearsOld -= numberOfYearsToAge;
    Console.WriteLine($"Modified age in method: {startingAge.YearsOld}");
}

static void Records()
{
    Console.WriteLine("========== Records = reference or value types ==========");

    PremiereCustomer pc = new PremiereCustomer
    {
        FirstName = "Customer",
        LastName = "One",
        Id = 7,
        Age = new Age { BirthDate = DateTime.Now, YearsOld = 1 },
        CustomerLevel = 1
    };

    PremiereCustomer pc2 = pc with { CustomerLevel = 2, LastName = "Two" };

    Console.WriteLine($"{pc.FirstName} {pc.LastName} has a level of {pc.CustomerLevel}");
    Console.WriteLine($"{pc2.FirstName} {pc2.LastName} has a level of {pc2.CustomerLevel}");
    ChangeName(pc);
    Console.WriteLine($"{pc.FirstName} {pc.LastName} is still {pc.Age.YearsOld}");
}

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