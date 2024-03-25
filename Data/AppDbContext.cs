using System.Data.Entity;
//using ToolsManagerApp.Data; 

public class AppDbContext : DbContext
{
    public AppDbContext() : base("name=DefaultConnection")
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Tool> Tools { get; set; }
    public DbSet<Category> Categories { get; set; }

    // Call this method to add a user
    public void AddUser(User user)
    {
        Users.Add(user);
        SaveChanges();
    }

    // Call this method to get a user
    public User GetUser(int id)
    {
        return Users.Find(id);
    }

    // Call this method to update a user
    public void UpdateUser(User user)
    {
        Entry(user).State = EntityState.Modified;
        SaveChanges();
    }

    // Call this method to delete a user
    public void DeleteUser(int id)
    {
        var user = Users.Find(id);
        if (user != null)
        {
            Users.Remove(user);
            SaveChanges();
        }
    }
}
