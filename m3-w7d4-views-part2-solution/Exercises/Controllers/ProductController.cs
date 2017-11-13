using Exercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product/List
        public ActionResult List()
        {
            return View("List", GetProductsForDisplay());
        }

        // GET: Product/Tile
        public ActionResult Tile()
        {
            return View("Tile", GetProductsForDisplay());
        }

        // GET: Product/Table
        public ActionResult Table()
        {
            return View("Table", GetProductsForDisplay());
        }

        public ActionResult Detail(string id)
        {
            var product = GetProductsForDisplay().Find(p => p.ProductId == id.ToUpper());
            return View("Detail", product);
        }


        private List<Product> GetProductsForDisplay()
        {
            return new List<Product>
            {
                new Product() { AverageRating = 4.4, ImageName="toy-balls.jpg", IsTopSeller=true, Manufacturer="Safe Kidz Toys", Name= "Stackable Balls", Price = 24.99, ProductId = "SKU-1234", RemainingStock = 5, WeightIbLbs= 2.0, Description = "The safest stackable balls for a baby. GIFT Ready, reduce teething injury, and sharpen your child's mind!" },
                new Product() { AverageRating = 3.4, ImageName="toy-car.jpg", IsTopSeller=false, Manufacturer="Safe Kidz Toys", Name= "Push and Pull Car", Price = 8.99, ProductId = "SKU-2345", RemainingStock = 5, WeightIbLbs= 2.0, Description = "Buckle up, because the Green Toys Race Car is ready to roll. Built in the USA from 100% recycled materials." },
                new Product() { AverageRating = 1.2, ImageName="toy-gym.jpg", IsTopSeller=false, Manufacturer="Crossfit Kids", Name= "Kid Gym", Price = 89.99, ProductId = "SKU-5678", RemainingStock = 19, WeightIbLbs= 25.0, Description = "Promotes safe, playful fitness participation and so much fun! Now your kids can join in the fun of overhead squats, cleans, & all those lifts you love to do." },
                new Product() { AverageRating = 4.1, ImageName="toy-horse.jpg", IsTopSeller=false, Manufacturer="Amazing Toys", Name= "Rocking Horse", Price = 34.99, ProductId = "SKU-3333", RemainingStock = 2, WeightIbLbs= 13.0, Description = "One of Little Tikes' classic items is back! Perfect for small indoor areas!" },
                new Product() { AverageRating = 5.0, ImageName="toy-snail.jpg", IsTopSeller=true, Manufacturer="Slow Toys", Name= "Drag-a-long Snail", Price = 8.99, ProductId = "SKU-4567", RemainingStock = 15, WeightIbLbs= 2.3, Description = "Perfect tagalong companion for little ones as they gain confidence in learning and exploring" },
                new Product() { AverageRating = 4.7, ImageName="toy-tricycle.jpg", IsTopSeller=true, Manufacturer="Safe Kidz Toys", Name= "My First Trike", Price = 24.99, ProductId = "SKU-5566", RemainingStock = 11, WeightIbLbs= 17.0, Description = "This Tricycle won Parents Choice Classic Award, Parents Guide to Children's Media Award, The National parenting Centers Seal of Approval. A controlled turning radius and low center of gravity make this tricycle easy for little ones to ride. The sturdy steel design and rubber tires make this tricycle durable." },

            };
        }

    }
}