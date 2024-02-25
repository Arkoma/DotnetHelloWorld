// See https://aka.ms/new-console-template for more information

using ClassesStructsAndRecords;

string dbName = Constants.CONFIG_DB_NAME;
Console.WriteLine(dbName);

Manager m = new Manager();
m.IsActive();

