using System;
using System.Collections.Generic;
namespace Bakery.Service.Models
{
    public class ProductModel
    {
        public long Id {get; set;}
        public string Name {get; set;}
        public long Price {get; set;}
        public long Quantity {get; set;}
        public string Category {get; set;}
    }
}