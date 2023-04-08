using Microsoft.EntityFrameworkCore; // DbContext

using static System.Environment;
using static System.IO.Path;

namespace Packt.Shared;

// this manages the connection to the database 
public class Northwind : DbContext
{
    // these properties map to tables in the database 
    public DbSet<Customer>? Customers { get; set; }

    protected override void OnConfiguring(
      DbContextOptionsBuilder optionsBuilder)
    {
        string path = Path.Combine(
          Environment.CurrentDirectory, "Northwind.db");

        optionsBuilder.UseSqlite($"Filename={path}");
        /*
    string connection = "Data Source=.;" +
        "Initial Catalog=Northwind;" +
        "Integrated Security=true;" +
        "MultipleActiveResultSets=true;";

    optionsBuilder.UseSqlServer(connection);
        */
    }

}