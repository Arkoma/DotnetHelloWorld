namespace ClassesStructsAndRecords
{
    static class Constants
    {
        // if you try to create a constructor the compiler 
        // gives you the following error:
        // Static class 'ClassesStructsAndRecords.Constants'
        // cannot have non-static constructor 'Constants()'
        // public Constants() { }
        public static string ConnectionString;

        public static readonly string CONFIG_SERVER_NAME = "TargetServer";
        public const string CONFIG_DB_NAME = "DatabaseName";

        public static DateTime GetDateTimeFromDateOnly(DateOnly input)
        {
            return new DateTime(input.Year, input.Month, input.Day);
        }
        
        static Constants()
        {
            ConnectionString = "Server=...";//config
        }
        
        
    }
}