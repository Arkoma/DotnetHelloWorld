namespace EnumsAndNullables;

using System;
// Write your answer here, and then test your code.
// Your job is to modify the Enum definition to enable multiple values.

[Flags]
public enum DaysOfWeek : short{
    // Your code goes here.
    Sunday = 1,
    Monday = 2,
    Tuesday = 4,
    Wednesday = 8,
    Thursday = 16,
    Friday = 32,
    Saturday = 64    // Doubling the values allows combinations to not conflict (e.g. Sunday + Monday = 3 which doesn't 
                     // conflict with any of the other values in the enum
}
public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
    public  static Boolean ShowExpectedResult = false;
    public  static Boolean ShowHints = false;
}