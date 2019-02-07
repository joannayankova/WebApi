using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPI.Controllers
{
    public class SumController : ApiController
    {
        //[System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public int  Sum(int paramOne,int paramTwo)
        {
            int sum = paramOne + paramTwo;
            return sum;

        }
    }
    public class SubtractController : ApiController
    {
        [System.Web.Http.HttpGet]
        public int Sub(int paramOne, int paramTwo)
        {
            int sub = paramOne - paramTwo;
            return sub;
        }
    }

    public class ProductController : ApiController
    {
        [System.Web.Http.HttpGet]
        public int Product(int paramOne, int paramTwo)
        {
            int product = paramOne*paramTwo;
            return product;
        }
    }

    public class DevisionController : ApiController
    {
        [System.Web.Http.HttpGet]
        public double Devision(int paramOne, int paramTwo)
        {

            double devision =(double) paramOne / paramTwo;
            return devision;
        }
    }
}
