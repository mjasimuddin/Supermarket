using BLL.Entites;
using BLL.Specifications;
using System;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public class ProductWithBrandsAndTypesSpecification : BaseSpecification<Product>
    {
        public ProductWithBrandsAndTypesSpecification(ProductSpecParams productParams)
                :base(x => 
                    (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
                    (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
                )
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
            AddOrderBy(p => p.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1), productParams.PageSize);
            
            //if (!string.IsNullOrEmpty(productParams.Sort))
            //{
            //    switch (productParams.Sort)
            //    {
            //        case "priceAsc":
            //            AddOrderBy(p => p.Price);
            //            break;
            //        case "priceDesc":
            //            AddOrderByDescending(p => p.Price);
            //            break;
            //        default:
            //            AddOrderBy(p => p.Name);
            //            break;
            //    }
            //}
        }

        public ProductWithBrandsAndTypesSpecification(int id) : base(p => p.Id == id)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
    }
}