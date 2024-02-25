namespace ClassesStructsAndRecords;

//classes - reference types
public class CPoint
{
    public int X { get; set; }
    public int Y { get; set; }
} 

//structs - value types
public struct SPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public static bool operator == (SPoint a, SPoint b) => a.X == b.X && a.Y == b.Y;
    public static bool operator != (SPoint a, SPoint b) => a.X != b.X || a.Y != b.Y;
}

public record RPoint(int X, int Y);
public interface IPerson 
{
    public string? FirstName { get; set; } 
    public string? LastName { get; set; } 
    public int Id { get; set; } 
    public Age Age { get; set; } 
}

//classes - reference types
public class Employee : IPerson
{
    public Employee()
    { }

    public Employee(string firstName, string lastName, int empId = 0)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = empId;
    }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id { get; set; }
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
    public void SetOrderId(int orderId)
    {
        OrderId = orderId;
    }
    public int OrderId { get; private set; }
    public DateOnly OrderDate { get; set; }

}
public record struct RecurringOrder
{

}