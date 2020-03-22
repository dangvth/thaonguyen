using PetStoreWebClient.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetStoreWebClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productView = new ProductViewHome();
            ViewBag.viewPet = productView.getViewPet(4);
            ViewBag.viewPetFood = productView.getViewPetFood(4);
            ViewBag.viewPetToy = productView.getViewPetToys(4);
            ViewBag.viewPetSaleOff = productView.getViewPetSaleOff();
            return View();
        }
    }
}