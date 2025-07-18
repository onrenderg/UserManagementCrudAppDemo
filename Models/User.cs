using System;
// “Bring in basic C# system features – things like strings, integers, etc.”

using System.Collections.Generic;
// “Support for handling lists, dictionaries, and other generic collections.”

using System.Linq;
// “Allows us to write LINQ queries – super handy for searching and filtering lists or database sets.”

using System.Web;
// “Provides types for handling web-based tasks (not directly used here, but often present in MVC apps).”

namespace UserManagementCrudAppDemo.Models
// “This is the logical folder where this class lives – it matches the folder structure of the app.”

{
    public class User
    // nlb“We're declaring a public class named ‘User’ – this will represent a row (new instance of this class new row )in our database's Users table.”
    //nlimp"to the database as a new row, you need to add it to the DbSet in UserContext and then call SaveChanges(). from public ActionResult Create(User user)"

    {
        public int Id { get; set; }
        // “This is the unique ID for each user. It’s an integer and usually auto-incremented in the database.”

        public string Name { get; set; }
        // “The user’s name – stored as a string.”

        public string Email { get; set; }
        // “The user’s email address – also a string.”

        public string PhoneNumber { get; set; }
        // “The user’s phone number – saved as a string too.”
    }
}
