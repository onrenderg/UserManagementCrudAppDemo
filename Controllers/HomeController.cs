using System;
// “Include basic C# functionalities like types and conversions.”

using System.Collections.Generic;
// “Support for collections like List<T> and Dictionary<K,V>.”

using System.Linq;
// “Include LINQ to query data using SQL-like syntax on objects.”

using System.Web;
using System.Web.Mvc;
// “Use ASP.NET MVC components like Controller and ActionResult.”

using UserManagementCrudAppDemo.Models;
// “Access app-specific models like User and UserContext from the Models folder.”




namespace UserManagementCrudAppDemo.Controllers
// “Group this controller logically under the Controllers namespace.”
{
    public class HomeController : Controller
    // “Define a controller named HomeController, deriving from MVC’s base Controller class.”
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
            // “Display the default home view when someone navigates to /Home/Index.”
        }

        // Create View
        public ActionResult Create()
        {
            return View();
            // “Display a form to create a new user.”
        }

        // CreateView Operation
        [HttpPost]
        public ActionResult Create(User user)
        // “Handle form submission when creating a new user.”
        {
            if (ModelState.IsValid)
            // “Ensure submitted data is valid according to the User model.”
            {
                using (var context = new UserContext())
                // “Create a DB context to interact with the database.”
                {
                    context.Users.Add(user);
                    // “Add the new user object to the Users table.”

                    context.SaveChanges();
                    // “Commit the addition to the database.”
                }

                return RedirectToAction("Index");
                // “After successful creation, go back to the home page.”
            }

            return View(user);
            // “If validation fails, re-render the form with the entered data.”
        }


        // GET: Show all users immediately
        public ActionResult Read()
        // “Display all users currently in the database.”
        {
            using (var context = new UserContext())
            // “Open a new database context.”
            {
                var users = context.Users.ToList();
                // “Fetch all rows from the Users table.”

                return View(users);
                // “Send the user list to the Read.cshtml view.”
            }
        }


        // GET: Load and show all users immediately
        public ActionResult Update()
        // “Show a list of users you can choose to update.”
        {
            using (var context = new UserContext())
            {
                var users = context.Users.ToList();
                // “Fetch all users from the database.”

                return View(users);
                // “Pass the users list to the Update.cshtml view.”
            }
        }


        // POST: Update operation handler
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateOperation(User user)
        // “Receive updated user data from the form.”
        {
            if (ModelState.IsValid)
            {
                using (var context = new UserContext())
                {
                    context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    // “Mark this user record as modified.”

                    context.SaveChanges();
                    // “Apply the update to the database.”
                }

                return RedirectToAction("Update");
                // “Go back to the user list after updating.”
            }

            return View("UpdateOperation", user);
            // “If something's wrong, show the same form again with entered data.”
        }


        // GET: Delete view and load users
        public ActionResult Delete()
        // “Show all users, each with a delete option.”
        {
            using (var context = new UserContext())
            {
                var users = context.Users.ToList();
                // “Fetch all users for display.”

                return View(users);
                // “Pass them to Delete.cshtml.”
            }
        }


        // POST: Delete by ID
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteOperation(int id)
        // “Handle deletion of a user by their ID.”
        {
            using (var context = new UserContext())
            {
                var user = context.Users.Find(id);
                // “Try to locate the user in the DB.”

                if (user != null)
                {
                    context.Users.Remove(user);
                    // “Remove the user from the table.”

                    context.SaveChanges();
                    // “Commit the delete to the database.”
                }
            }

            return RedirectToAction("Delete");
            // “Return to the delete list after operation.”
        }


    }
}
