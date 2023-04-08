using Packt.Shared;

using static System.Console;

Write("Enter the name of a city: ");
string? cityName = ReadLine();

using (Northwind db = new Northwind())
{
    var queryCustomer=db.Customers?.Where(c => c.City==cityName);
    if (queryCustomer is not null)
    {
        WriteLine($"There are {queryCustomer.Count()} in that city:");
        foreach (var customer in queryCustomer)
        {
            WriteLine("\t"+customer.CompanyName);
        }
    }
}

using (Northwind db = new Northwind())
{
    var queryCityCustomer = db.Customers?.Select(c => c.City).Distinct();
    if (queryCityCustomer is not null)
    {
        WriteLine($"{string.Join(", ", queryCityCustomer)}");
    }
}
