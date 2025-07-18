// Models/UserContext.cs
using System.Data.Entity;
// “Hey C#, bring in the Entity Framework functionality so we can interact with databases using classes.”

using UserManagementCrudApp.Models;
// “Also bring in the models we've defined for our app, like the User class.”

namespace UserManagementCrudAppDemo.Models
// “We're working inside the UserManagementCrudApp.Models namespace – it's like a folder for related code.”

{
    public class UserContext : DbContext
    // “Define a new class named UserContext that inherits from Entity Framework’s DbContext – this sets up the database access layer.”

    {
        public UserContext() : base("DefaultConnection") { }
        // “Create a constructor for UserContext. When someone creates an instance of this class, use the connection string named ‘DefaultConnection’ from Web.config to connect to the database.”

        public DbSet<User> Users { get; set; }
        // “Set up a table called ‘Users’ in the database that maps to our User model. Now we can run LINQ queries like context.Users.ToList() to interact with the data.”

    }
}

// Entity Framework 6 (EF6):
// UserContext inherits from DbContext, the base class used for database operations in EF.
// The constructor: base("DefaultConnection") tells EF to use the connection string named DefaultConnection, usually defined in Web.config.
// DbSet<User> Users maps to your Users table in the database.
