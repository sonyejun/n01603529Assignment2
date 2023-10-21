using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603529Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        //Adapted J2 - Roll the Dice
        //GET : api/J2/DiceGame/{m}/{n}
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int target = 10; //total target num
            int count = 0; //ways count
            for(int i = 1; i <= m; i++)//first num
            {
                for (int j = 1; j <= n; j++)//second num
                {
                    if(i + j == target)//If the sum of M and N is 10, increase the counter
                    {
                        count++;
                    }
                }
            }
            return "There are "+ count + " ways to get the sum "+ target +".";
        }
    }
}
