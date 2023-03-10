
using BLL.Entites;
using BLL.Specifications;

namespace BLL.Specifications
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productParams)
                : base(x =>
                     (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
                     (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
                )
        {

        }
    }
}