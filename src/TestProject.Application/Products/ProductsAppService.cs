using Abp.Application.Services;
using Abp.Domain.Repositories;

namespace TestProject.Products
{
    public class ProductsAppService : CrudAppService<Product, Product.ProductDto>
    {
        public ProductsAppService(IRepository<Product, int> repository) : base(repository)
        {

        }
    }
}
