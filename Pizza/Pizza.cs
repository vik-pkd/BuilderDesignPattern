using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    /*
     * <summary>
     *  Pizza has properties size, crustType, calories, toppings
     * </summary>
     */
    public class Pizza
    {
        public string size;
        public string crustType;
        public int calories;
        public string toppings;
        public Pizza()
        { 
            calories = 0;
            size = string.Empty;
            crustType = string.Empty;
            toppings = string.Empty;
        }
    }
}
