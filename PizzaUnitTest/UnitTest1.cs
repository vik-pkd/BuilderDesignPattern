using PizzaApp;

namespace PizzaUnitTest
{
    /*
     * <summary>
     *  Unit tests for the builder design pattern demo.
     * </summary>
     */

    [TestClass]
    public class UnitTest1
    {

        /* 
         * <summary>
         *  Creates and object of Pizza and asserts if object is constructed correctly
         * </summary>
         */
        [TestMethod]
        public void PizzaTest1()
        {
            PizzaBuilder builder = new();
            Pizza pizza =  builder
                .SetToppings("Pineapple")
                .SetSize("Large")
                .SetCrustType("hand-tossed")
                .SetCalories(600)
                .Build();

            Assert.IsTrue(pizza.toppings == "Pineapple" &&
                            pizza.size == "Large" &&
                            pizza.crustType == "hand-tossed" &&
                            pizza.calories == 600
                            );
        }
    }
}