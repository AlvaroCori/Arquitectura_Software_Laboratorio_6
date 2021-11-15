using System;
using System.Collections.Generic;
namespace Bakery.Domain.Entities
{
    public class ProductEntity
    {
        public long Id {get; set;}
        public string Name {get; set;}
        public float Price {get; set;}
        public long Quantity {get; set;}
        public string Category {get; set;}
    }
}