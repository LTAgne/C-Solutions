using SSGeek.DAL;
using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class StoreController : Controller
    {
        private const string ShoppingCart_SessionKey = "ShoppingCart";
        private readonly IProductDAL productDal;

        public StoreController(IProductDAL productDal)
        {
            this.productDal = productDal;
        }

        // GET: Store
        public ActionResult Index()
        {
            var products = productDal.GetProducts();
            return View("Index", products);
        }

        // GET: Store/Detail/id
        public ActionResult Detail(int id)
        {
            // Check to make sure that the id is for a valid product
            var product = productDal.GetProduct(id);

            if (product == null)
            {
                return new HttpNotFoundResult(); //404
            }

            return View("Detail", product);
        }

        [HttpPost]
        public ActionResult AddToCart(int productId, int quantity)
        {
            // Check to make sure that they are purchasing a valid product
            var product = productDal.GetProduct(productId);

            if (product == null)
            {
                return new HttpNotFoundResult();
            }

            // Check to see if a shopping cart exists in session, if not create it
            if (Session[ShoppingCart_SessionKey] == null)
            {
                Session[ShoppingCart_SessionKey] = new ShoppingCart();
            }

            // Retrieve the cart from session
            var shoppingCart = Session[ShoppingCart_SessionKey] as ShoppingCart;

            // Add the product or update the quantity
            shoppingCart.AddOrUpdateCart(product, quantity);

            // Store cart back in session
            Session[ShoppingCart_SessionKey] = shoppingCart;

            return RedirectToAction("ViewCart");
        }

        // GET: Store/ViewCart
        public ActionResult ViewCart()
        {
            ShoppingCart model = new ShoppingCart();

            // Retrieve cart from session
            if (Session[ShoppingCart_SessionKey] != null)
            {
                model = (ShoppingCart)Session[ShoppingCart_SessionKey];
            }

            return View("ViewCart", model);
        }


    }
}