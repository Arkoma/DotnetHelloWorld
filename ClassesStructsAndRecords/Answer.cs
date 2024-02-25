namespace ClassesStructsAndRecords;

using System;
using System.Linq;

// my answer ... it works but...
// public class Answer
// {
//     public string Name {get;set;}
//     public int Age {get;set;}
//     public DateTime HireDate {get;set;}
//
//     public static bool operator == (Answer a, Answer b) =>
//         a.Name == b.Name && a.Age == b.Age && a.HireDate == b.HireDate;
//
//     public static bool operator !=(Answer a, Answer b) =>
//         a.Name != b.Name || a.Age != b.Age || a.HireDate != b.HireDate;
// }

// the solution is simpler
public record Answer
{
    public string Name {get;set;}
    public int Age {get;set;}
    public DateTime HireDate {get;set;}
}