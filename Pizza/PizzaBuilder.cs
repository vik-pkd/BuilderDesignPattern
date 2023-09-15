using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    /*
     * <summary>
     *  PizzaBuilder has functions for setting each property of Pizza
     * </summary>
     */
    public class PizzaBuilder
    {
        private readonly Pizza _pizza;
        public PizzaBuilder()
        { 
            _pizza = new();
        }

        /*
         * <summary>
         *  PizzaBuilder returns Pizza after build function
         * </summary>
         */
        public Pizza Build()
        {
            return _pizza;
        }

        public PizzaBuilder SetSize(string size)
        {
            _pizza.size = size;
            return this;
        }

        public PizzaBuilder SetCrustType(string crustType)
        {
            _pizza.crustType = crustType;
            return this;
        }

        public PizzaBuilder SetCalories(int calories)
        {
            _pizza.calories = calories;
            return this;
        }

        public PizzaBuilder SetToppings(string toppings)
        {
            _pizza.toppings = toppings;
            return this;
        }
    }
}
