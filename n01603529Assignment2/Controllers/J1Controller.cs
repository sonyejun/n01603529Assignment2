using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603529Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        //For J1 - The new ccc
        //GET : api/J1/Menu/{burger}/{drink}/{side}/{dessert}
        [HttpGet]
        [Route("api/J1/Menu/{buger}/{drink}/{side}/{dessert}")]
        public int Menu(int buger, int drink, int side, int dessert)
        {

            //Buger prices List
            List<int> Burgers = new List<int>();
            Burgers.Add(461); //1 - Cheeseburger (461 Calories)
            Burgers.Add(431); // 2 - Fish Burger(431 Calories)
            Burgers.Add(420); // 3 - Veggie Burger(420 Calories)
            Burgers.Add(0); // 4 - no burger

            //Drinks prices List
            List<int> Drinks = new List<int>();
            Drinks.Add(130); //1 - Soft Drink(130 Calories)
            Drinks.Add(160); //2 - Orange Juice(160 Calories)
            Drinks.Add(118); //3 - Milk(118 Calories)
            Drinks.Add(0); //4 - no drink

            //Sides prices List
            List<int> Sides = new List<int>();
            Sides.Add(100); //1 - Fries(100 Calories)
            Sides.Add(57); //2 - Baked Potato(57 Calories)
            Sides.Add(70); //3 - Chef Salad(70 Calories)
            Sides.Add(0); //4 - no side order

            //Desserts prices List
            List<int> Desserts = new List<int>();
            Desserts.Add(167); //1 - Apple Pie(167 Calories)
            Desserts.Add(266); //2 - Sundae(266 Calories)
            Desserts.Add(75); //3 - Fruit Cup(75 Calories)
            Desserts.Add(0); //4 - No Dessert

            int result = Burgers[buger - 1] + Drinks[drink - 1] + Sides[side - 1] + Desserts[dessert - 1];
            return result;
        }
    }
}
