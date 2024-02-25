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

public class Age
{
}

//classes - reference types
public abstract class Employee : IPerson
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
    // public int EmployeeId { get; set; }
    public DateOnly StartDate { get; set; }
    public TimeOnly ShiftStartTime { get; set; }
    
    //virtual property
    public virtual DateTime EndDate { get; set; }
    
    //abstract property
    public abstract int EmployeeId { get; }
    
    //derived must implement
    public abstract bool ProcessPayroll();

    //derived can implement
    public virtual void Terminate(DateTime terminationEffectiveDate)
    {
        Console.WriteLine("Employee terminated");
        EndDate = terminationEffectiveDate;
    }
    
    //derived can call or hide
    public bool IsActive()
    {
        Console.WriteLine("Employee Active");
        DateOnly current = DateOnly.FromDateTime(DateTime.Now);
        return current > StartDate && DateTime.Now < EndDate;
    }
}  

public class ShiftWorker: Employee
{
    public TimeOnly ShiftStartTime { get; set; }
    public override int EmployeeId { get => 1; }
    public override bool ProcessPayroll()
    {
        Console.WriteLine("Shiftworker payroll");
        return true;
    }

    public new bool IsActive()
    {
        Console.WriteLine("Shiftworker active");
        return false;
    }
}

public class Manager : Employee, IPerson
{
    public int NumberOfDirectReports { get; set; }
    public override int EmployeeId
    {
        get => new Random().Next(1, 100);
    }

    public override bool ProcessPayroll()
    {
        Console.WriteLine("Manager Payroll");
        return true;
    }

    // public override void Terminate(DateTime terminationEffectiveDate)
    public new void Terminate(DateTime terminationEffectiveDate)
    {
       //if override is used it is called whether typed as
       //base clase or derived class
       //if new base method is called if typed as base 
       //class or derived class if typed as derived
        
        //perform manager specific termination steps
        Console.WriteLine("Manager terminated");
        
        //optional - call base implementation;
        base.Terminate(terminationEffectiveDate);
    }
}

