using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /* SOLUTION
     * Define all price levels per set size (e.g. 1 book costs 8.0, 2 unique books cost $15.20, etc.
     * Build a basket that represents the quantity of each book purchased
     * Iterate through the basket as necessary as long as items remain
     *  Iterate thru and check to see if there is a book 1, if yes - add to set and remove from basket
     *  Iterate thru and check to see if there is a book 2, if yes - add to set and remove from basket
     *  ...
     *  Get the cost of that set and add it to the sum 
     *  except If we've got 3 books in the basket and we've got a set of 5..its cheaper to break into 2 sets of 4
     */
    public class KataPotter
    {        
        public decimal GetCost(int[] books)
        {                  
            decimal sum = 0.0M;
            decimal[] priceLevels = { 0M, 8.0M, 15.2M, 21.6M, 25.6M, 30.0M };
            
            int[] basket = new int[5]; 
            for (int i = 0; i < books.Length; i++)
            {
                basket[books[i]]++;         
            }

            while (basket.Sum() > 0)
            {
                int booksInTheSet = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (basket[i] != 0)
                    {
                        basket[i]--;
                        booksInTheSet++;
                    }
                }

                // Its cheaper to get 2 sets of 4 than a set of 5 and a set of 3
                if (booksInTheSet == 5 && basket.Sum() == 3 && !basket.Contains(3))
                {
                    sum += priceLevels[4] * 2;
                    break;
                }

                sum += priceLevels[booksInTheSet];
            }            

            return sum;
        }
    }
}
