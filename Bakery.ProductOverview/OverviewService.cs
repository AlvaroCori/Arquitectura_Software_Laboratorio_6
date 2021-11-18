using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Domain;
using Bakery.Domain.Entities;
using Bakery.ProductOverviewService.Models;

namespace Bakery.ProductOverviewService
{
    public class OverviewService: IOverviewService
    {
        private IBakeryRepository _repository;
        public OverviewService(IBakeryRepository repository)
        {
            _repository = repository;
        }
        public OverviewModel GetOverview(string category)
        {
            var products = _repository.GetProducts();
            var productsOfTheCategory = products.Where(product => product.Category == category);
            var quantity = productsOfTheCategory.Count();
            var totalPrice = productsOfTheCategory.Select(product => product.Price).Sum();
            OverviewModel overview = new OverviewModel()
            {
                Id = 0,
                NameProduct = category,
                Quantity = quantity,
                Total = totalPrice
            };
            return overview;
        }
        public ICollection<OverviewModel> GetOverviews()
        {
            ICollection<OverviewModel> overviews = new List<OverviewModel>();
            var products = _repository.GetProducts();
            var categories = products.Select(product => product.Category).Distinct();
            var id = 1;
            foreach (var category in categories)
            {
                var overview = GetOverview(category);
                overview.Id = id;
                overviews.Add(overview);
                id = id + 1;
            }
            return overviews;
        }
    }
}
