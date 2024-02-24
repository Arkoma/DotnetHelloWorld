namespace ClassesStructsAndRecords;

public interface IPerson 
{
    public string? FirstName { get; set; } 
    public string? LastName { get; set; } 
    public int Id { get; set; } 
    public Age Age { get; set; } 
}

//classes - reference types
public class Employee(string firstName, string lastName, int empId = 0 /*this is a default value*/) : IPerson
{
    // gets a compiler warning that Default parameter value for 'empId' must be a compile-time constant
    // public Employee(string firstName, string lastName, int empId = new Random().Next(1, 10))
    // {
        // FirstName = firstName;
        // LastName = lastName;
        // Id = empId;
    // }

    public string? FirstName { get; set; } = firstName;
    public string? LastName { get; set; } = lastName;
    public int Id { get; set; } = empId;
    public Age Age { get; set; }
    
    //employee properties
    public int EmployeeId { get; set; }
    public DateOnly StartDate { get; set; }
    public TimeOnly ShiftStartTime { get; set; }
}  

public class Manager : Employee
{
    public Manager(string firstName, string lastName) : base(firstName, lastName) { }
    
    public int NumberOfDirectReports { get; set; }
}

//structs - value types
public struct Age
{
    public Age () {}
    public DateTime BirthDate { get; set; }
    public int YearsOld { get; set; }
}

public struct VendorContact : IPerson
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
}

//records (C# 9)
public record Customer : IPerson
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
}


public record PremiereCustomer : Customer
{
    public byte CustomerLevel { get; init; }
}

//record structs (C# 10)
public record struct Order
{
    public int OrderId { get; set; }
    public DateOnly OrderDate { get; set; }

}
public record struct RecurringOrder
{

}