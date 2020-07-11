using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Example>
    {
        public ProductsWithTypesAndBrandsSpecification(ExampleSpecParams productParams) : base(x =>
           (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
           (!productParams.ExampleId.HasValue || x.ExampleItemId == productParams.ExampleId)
        )
        {
            AddInclude(x => x.ExampleItem);
            //AddOrderBy(x => x.Name);
            ApplyPagging(productParams.PageSize * (productParams.PageIndex - 1), productParams.PageSize);
            //AddOrderByDescending(p => p.Price);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public ProductsWithTypesAndBrandsSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ExampleItem);
        }
    }
}