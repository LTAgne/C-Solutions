using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class ShoppingCart
    {

        private int totalNumberOfItems = 0;
        private decimal totalAmountOwed = 0.0M;

        public int TotalNumberOfItems
        {
            get { return this.totalNumberOfItems; }
        }

        public decimal TotalAmountOwed
        {
            get { return this.totalAmountOwed; }
        }


        /**
        * The average price of all items that have been added to the cart.  This should be equal to 
        * the totalAmountOwed divided by the totalNumberOfItems.
        * 
        * @return the average price of items added to the cart
        */
        public decimal GetAveragePricePerItem()
        {
            if (this.totalNumberOfItems == 0)
            {
                return 0;
            }
            else
            {
                return this.totalAmountOwed / this.totalNumberOfItems;
            }
        }

        /**
        * Adds items to the cart.
        * 
        * @param numberOfItems the number of items being added to the cart
        * @param pricePerItem the price per item being added to the cart
        */
        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            this.totalNumberOfItems += numberOfItems;
            this.totalAmountOwed += (pricePerItem * numberOfItems);
        }

        /**
        * Removes all items from this cart.
        */
        public void Empty()
        {
            this.totalNumberOfItems = 0;
            this.totalAmountOwed = 0;
        }
    }
}
