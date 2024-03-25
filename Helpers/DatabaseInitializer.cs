using System.Data.Entity;

public class DatabaseInitializer : CreateDatabaseIfNotExists<AppDbContext>
{
    protected override void Seed(AppDbContext context)
    {
        // Seed the database with default data
        context.Users.Add(new User { Name = "Admin", Role = RoleEnum.Admin });
        // ... Add other seed data

        base.Seed(context);
    }
}
