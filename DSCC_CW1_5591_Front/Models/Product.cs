using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSCC_CW1_5591_Front.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public virtual  Category CategoryName { get; set; }
    }
}