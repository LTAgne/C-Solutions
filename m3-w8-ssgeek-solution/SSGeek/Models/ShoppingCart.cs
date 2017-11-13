using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGeek.Models
{
    public class ShoppingCart
    {
        // property to hold all items added to the shopping cart
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        // derived property to get the grand total of the shopping cart
        public double GrandTotal
        {
            get
            {
                return Items.Sum(item => item.Subtotal); //<-- sums up the subtotal of each shopping cart item
            }
        }

        public void AddOrUpdateCart(Product product, int quantity)
        {
            var existingItem = Items.Where(item => item.Product.ProductId == product.ProductId).FirstOrDefault();
            if(existingItem != null)
            {
                existingItem.Quantity = quantity;
            }
            else
            {
                Items.Add(new ShoppingCartItem()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
        }
    }

    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }        

        // derived property that calculates the product price * quantity
        public double Subtotal
        {
            get
            {
                if (Product == null)
                {
                    return 0.0;
                }
                else
                {
                    return Product.Price * Quantity;
                }
            }
        }
    }
}