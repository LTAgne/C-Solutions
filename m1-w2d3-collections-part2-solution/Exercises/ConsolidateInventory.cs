using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionarys, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2, 
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         * 
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *  
         * consolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         * 
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
            Dictionary<string, int> remoteWarehouse)
        {
            // We don't need a new dictionary
            foreach (KeyValuePair<string, int> kvp in remoteWarehouse)
            {
                string sku = kvp.Key;
                int value = kvp.Value;

                // if it contains it, add to it
                if (mainWarehouse.ContainsKey(sku))
                {
                    mainWarehouse[sku] = mainWarehouse[sku] + value;
                }
                else // add the value of the sku by itself
                {
                    mainWarehouse[sku] = value;
                }
            }

            return mainWarehouse;
        }
    }
}
