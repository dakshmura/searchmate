using Microsoft.AspNetCore.Mvc;
using searchmate.Models;

public class AccountController : Controller
{
    public ActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Register(UserModel model)
    {
        Console.WriteLine("Registration Successful!");
        // Handle registration logic here (e.g., saving to database)
        // Redirect to login page after successful registration
        return RedirectToAction("Register", "Account");
    }
}
