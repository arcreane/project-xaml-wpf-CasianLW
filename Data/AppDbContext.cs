using System.Data.Entity;
using ToolsManagerApp.Data; 

public class AppDbContext : DbContext
{
    public AppDbContext() : base("name=DefaultConnection") // This should match the name of the connection string in your config file
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Tool> Tools { get; set; }
    public DbSet<Category> Categories { get; set; }
    // ... other DbSets for your models
}
