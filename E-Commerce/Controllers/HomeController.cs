using Bogus;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> products=new();
        public HomeController()
        {
            Faker faker = new();
            Product product1 = new()
            {
                Name = faker.Commerce.ProductName(),
                ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcThdtogrPsOcQeuKm62SJPEtDkgK6_WNZ02ppcOec5gepVlso_J",
                Description = faker.Commerce.ProductDescription(),
                Price = faker.Commerce.Price()
            };
            products.Add(product1);
            faker=new();
            Product product2 = new()
            {
                Name=faker.Commerce.ProductName(),
                Description=faker.Commerce.ProductDescription(),
                Price=faker.Commerce.Price(),
                ImageUrl= "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Kiwi_%28Actinidia_chinensis%29_1_Luc_Viatour.jpg/640px-Kiwi_%28Actinidia_chinensis%29_1_Luc_Viatour.jpg"
            };
            products.Add(product2);
        }
        
        public IActionResult Index()
        {
            return View(products);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
    }
}