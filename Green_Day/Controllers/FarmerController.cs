using Green_Day.Models;
using Green_Day.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Green_Day.Controllers
{
    public class FarmerController : Controller
    {
        // GET: Farmer Dashboard
        public ActionResult Dashboard()
        {
            Farmers viewModel = new Farmers
            {
                First_Name = "John",
                Last_Name= "Cena",
                Email = "john@example.com"
            };
            return View(viewModel);
        }

        // POST: Add Product
        [HttpPost]
        public ActionResult AddProduct(string productName)
        {
            // Add logic to handle the addition of a new product to the farmer's profile
            // Save the product to the database or perform any other necessary operations
            // Redirect to appropriate page afterward

            return RedirectToAction("Dashboard");
        }
    }
}
