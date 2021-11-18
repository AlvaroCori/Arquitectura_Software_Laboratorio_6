using System;

namespace Bakery.ProductOverviewService.Models
{
    public class OverviewModel
    {
                public long Id {get; set;}
                public string NameProduct {get; set;}
                public long Quantity {get; set;}
                public float Total {get; set;}
    }
}
