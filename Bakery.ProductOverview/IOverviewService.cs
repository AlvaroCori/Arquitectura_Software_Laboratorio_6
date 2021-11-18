using System;
using Bakery.ProductOverviewService.Models;
using System.Collections.Generic;
namespace Bakery.ProductOverviewService
{
    public interface IOverviewService
    {
        ICollection<OverviewModel> GetOverviews();
    }
}
