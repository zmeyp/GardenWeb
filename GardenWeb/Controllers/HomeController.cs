using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GardenWeb.Data;

namespace GardenWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var products = _productRepository.GetProducts();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> GetFooterTask()
        {
            return PartialView("~/Views/Shared/_Footer.cshtml", await GetAddressAsync());
        }


        private static async Task<Address> GetAddressAsync()
        {
            await Task.Delay(1000);

            var address = new Address
            {
                AddressLine1 = "5817 N Placita Paisaje",
                City = "Tucson",
                State = "AZ",
                Zip = "85750"
            };

            return address;
        }
    }
}