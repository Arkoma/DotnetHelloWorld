// C# code​​​​​​‌​‌​‌‌​‌​‌‌‌‌​​​​‌​‌‌‌‌‌‌ below
using System;
using System.Linq;
// Write your answer here, and then test your code.
// Your job is to implement the ComputeDiscountLevel method.

public record Order
{
    public decimal Total { get; set; }
    public char CustomerTier { get; set; } //S = Silver, G=Gold, P=Platinum
}
public class Answer
{

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
    public static Boolean ShowExpectedResult = false;
    public static Boolean ShowHints = false;

    // Return the discount level ('High', 'Low', 'Standard')
    // based on the order total; using property patterns.
    public static string ComputeDiscountLevel(Order customerOrder) => customerOrder switch
    {
        { Total: < 100 } => "Low",
        { Total: > 1000 } => "High",
        _ => "Standard"
    };

}
