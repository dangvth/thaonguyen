using PetStoreWebClient.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetStoreWebClient.Controllers
{
    public class CartController : Controller
    {
        private const String cartSession = "cartSession";

        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session[cartSession];
            var list = new List<CartItem>();
            var listCartPetFood = new List<CartPetFoodItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
                foreach (var item in list)
                {
                    if (item.productID.StartsWith("PFD"))
                    {
                        EF.PetFood pf = new PetFoodModel().getPetFoodByID(item.productID);
                        CartPetFoodItem cpfi = new CartPetFoodItem();
                        cpfi.Petfood = pf;
                        cpfi.Quantity = item.Quantity;
                        listCartPetFood.Add(cpfi);
                    }
                }
            }
            return View(listCartPetFood);
        }

        public ActionResult AddItem(String productID, int Quantity)
        {
            var cart = Session[cartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.productID == productID))
                {
                    foreach (var item in list)
                    {
                        if (item.productID == productID)
                        {
                            item.Quantity += Quantity;
                        }
                    }
                }else
                {
                    //create Cart item object
                    var item = new CartItem();
                    item.productID = productID;
                    item.Quantity = Quantity;
                    list.Add(item);
                }

                //get to session
                Session[cartSession] = list;
            }
            else
            {
                //create Cart item object
                var item = new CartItem();
                item.productID = productID;
                item.Quantity = Quantity;
                var list = new List<CartItem>();
                list.Add(item);

                //get to session
                Session[cartSession] = list;
            }
            return RedirectToAction("Index");
        }
    }
}