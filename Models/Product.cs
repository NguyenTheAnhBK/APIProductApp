using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public string category { set; get; }
        public decimal price { set; get; }
    }
}