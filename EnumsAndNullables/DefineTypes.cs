namespace EnumsAndNullables;

public enum ShiftDays
{
    Sunday = 1,
    Monday = 2,
    // Sunday and Monday = 3
    Tuesday = 4,
    Wednesday = 8,
    Thursday = 16,
    Friday = 32,
    Saturday = 64
}


public class ShiftWorker: Employee
{
    public ShiftDays DaysAvailable { get; set; }
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

public abstract class Employee : IPerson
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id { get; set; }
    public Age? Age { get; set; }
    
    //employee properties
    // public int EmployeeId { get; set; }
    public DateOnly StartDate { get; set; }
    
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
        // internal bool IsActive() // available in the same assembly
        // protected bool IsActive() // available in the same class and derived classes but not in the same assembly outside 
        //                           // of those classes
    {
        Console.WriteLine("Employee Active");
        DateOnly current = DateOnly.FromDateTime(DateTime.Now);
        return current > StartDate && DateTime.Now < EndDate;
    }
    
}  

public interface IPerson 
{
    public string? FirstName { get; set; } 
    public string? LastName { get; set; } 
    public int Id { get; set; } 
    public Age? Age { get; set; } 
}

public class Age
{
}