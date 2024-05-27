using Khumalo_Craft.Data;
using Khumalo_Craft.Models;
using Microsoft.AspNetCore.Mvc;

namespace Khumalo_Craft.Controllers
{
    public class LoginController : Controller
    {
        private readonly Khumalo_CraftContext _context;

        public LoginController(Khumalo_CraftContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Returns the Login.cshtml view
        }

        [HttpPost]
        public IActionResult Index(LoginModel model) // Model passed as parameter
        {
            // Implement your authentication logic here (e.g., Database check)
            // If successful, redirect to desired page
            if (IsValidUser(model.Email, model.Password)) // Replace with your validation logic
            {
                return RedirectToAction("Index", "Home"); // Redirect to Home controller's Index action
            }

            // If login fails, return the view with error message (optional)

            ModelState.AddModelError("", "Invalid email or password");
            return View(model); // Re-render view with error message
        }

        private bool IsValidUser(string Email, string password) // Replace with your logic
        {
            bool valid = false;
            if(_context.User.Where(x=>x.Email==Email).FirstOrDefault() is not null)
            {
                if(_context.User.Where(x => x.Email == Email).FirstOrDefault().Password==password)
                {
                    valid = true;
                    int userID = _context.User.Where(x => x.Email == Email && x.Password==password).FirstOrDefault().UserId;
                    HttpContext.Session.SetInt32("userID", userID);
                }
            }
            return valid;
            
        }

    }
}
